using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    public partial class ResolverForm : Form
    {
        private List<(int a, int b, int c, string sol1, string sol2, string typeSolution)> resultData;
        private bool isHovering = false; // Variable pour l'effet de survol

        public ResolverForm()
        {
            InitializeComponent();

            // Initialiser le ComboBox avec les options de filtrage
            cmbFilterSolutions.Items.AddRange(new[] { "Toutes", "Réelles", "Imaginaire" });
            cmbFilterSolutions.SelectedIndex = 0; // Par défaut sur "Toutes"
            cmbFilterSolutions.SelectedIndexChanged += cmbFilterSolutions_SelectedIndexChanged;

            // Associer l'événement Paint pour un style personnalisé de btnValidate
            btnValidate.Paint += new PaintEventHandler(btnValidate_Paint);
            btnValidate.MouseEnter += (s, e) => { isHovering = true; btnValidate.Invalidate(); };
            btnValidate.MouseLeave += (s, e) => { isHovering = false; btnValidate.Invalidate(); };
        }

        private void btnValidate_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 30; // Rayon pour des coins très arrondis
            Color borderColor = isHovering ? Color.DodgerBlue : Color.DarkSlateGray;
            Color fillColor = isHovering ? Color.LightSkyBlue : Color.MediumSlateBlue;
            Color textColor = isHovering ? Color.White : Color.WhiteSmoke;

            // Définir la forme du bouton avec des coins arrondis
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);

            // Remplir le fond du bouton
            using (SolidBrush brush = new SolidBrush(fillColor))
            {
                graphics.FillPath(brush, path);
            }

            // Dessiner la bordure
            using (Pen pen = new Pen(borderColor, 2))
            {
                graphics.DrawPath(pen, path);
            }

            // Dessiner le texte du bouton
            TextRenderer.DrawText(graphics, btn.Text, btn.Font, btn.ClientRectangle, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void chkCustomFileName_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomFileName.Visible = chkCustomFileName.Checked;
            label3.Visible = chkCustomFileName.Checked;
            label4.Visible = chkCustomFileName.Checked;
            cmbFilterSolutions.Visible = chkCustomFileName.Checked;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string outputFileName = chkCustomFileName.Checked && !string.IsNullOrWhiteSpace(txtCustomFileName.Text)
                ? txtCustomFileName.Text + ".csv"
                : "Resultat.csv";

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Veuillez sélectionner un fichier CSV valide.");
                return;
            }

            try
            {
                resultData = new List<(int a, int b, int c, string sol1, string sol2, string typeSolution)>();

                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine(); // Ignorer l'en-tête

                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');

                        if (values.Length >= 3 && int.TryParse(values[0], out int a) && int.TryParse(values[1], out int b) && int.TryParse(values[2], out int c))
                        {
                            var solutions = EquationSolver.SolveQuadratic(a, b, c);
                            string typeSolution;
                            if (solutions.sol1.Contains("i") || solutions.sol2.Contains("i"))
                            {
                                typeSolution = "Imaginaire";
                            }
                            else
                            {
                                typeSolution = "Réelles";
                            }

                            resultData.Add((a, b, c, solutions.sol1, solutions.sol2, typeSolution));
                        }
                    }
                }

                using (var writer = new StreamWriter(outputFileName))
                {
                    writer.WriteLine("a,b,c,sol1,sol2,typeSolution");

                    foreach (var result in resultData)
                    {
                        writer.WriteLine($"{result.a},{result.b},{result.c},{result.sol1},{result.sol2},{result.typeSolution}");
                    }
                }

                ApplyFilter();

                MessageBox.Show($"Fichier {outputFileName} créé avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture ou de l'écriture du fichier : " + ex.Message);
            }
        }

        private void cmbFilterSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string selectedFilter = cmbFilterSolutions.SelectedItem.ToString();

            var filteredData = resultData.Where(result =>
                selectedFilter == "Toutes" ||
                (selectedFilter == "Réelles" && result.typeSolution == "Réelles") ||
                (selectedFilter == "Imaginaire" && result.typeSolution == "Imaginaire")
            ).Select(r => new { r.a, r.b, r.c, r.sol1, r.sol2, r.typeSolution }).ToList();

            dataPreview.DataSource = filteredData;
        }

        private void ResolverForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonfermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

public static class EquationSolver
{
    public static (string sol1, string sol2) SolveQuadratic(int a, int b, int c)
    {
        try
        {
            // Vérifier que a est non nul pour avoir une équation du second degré
            if (a == 0)
            {
                return ("Ce n'est pas une équation du second degré", "");
            }

            // Calcul du discriminant
            double discriminant = b * b - 4 * a * c;

            // Cas où le discriminant est positif : deux solutions réelles distinctes
            if (discriminant > 0)
            {
                double sqrtD = Math.Sqrt(discriminant);
                double sol1 = (-b + sqrtD) / (2 * a);
                double sol2 = (-b - sqrtD) / (2 * a);
                return (sol1.ToString("F2"), sol2.ToString("F2"));
            }
            // Cas où le discriminant est zéro : une solution réelle double
            else if (discriminant == 0)
            {
                double sol = -b / (2.0 * a);
                return (sol.ToString("F2"), ""); // Retourner la solution unique comme première solution
            }
            // Cas où le discriminant est négatif : solutions complexes
            else
            {
                double realPart = -b / (2.0 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                // Remplacer 0 par une chaîne vide dans la partie réelle et imaginaire
                string realPartStr = realPart == 0 ? "" : realPart.ToString("F2");
                string imaginaryPartStr;
                if (imaginaryPart == 1)
                {
                    imaginaryPartStr = "i";
                }
                else if (imaginaryPart == -1)
                {
                    imaginaryPartStr = "-i";
                }
                else
                {
                    imaginaryPartStr = imaginaryPart == 0 ? "" : $"{imaginaryPart:F2}i";
                }

                // Construire les deux solutions complexes
                string sol1 = $"{realPartStr}{(imaginaryPart > 0 ? " + " : " ")}{imaginaryPartStr}".Trim();
                string sol2 = $"{realPartStr}{(imaginaryPart < 0 ? " + " : " - ")}{imaginaryPartStr}".Trim();

                return (sol1, sol2);
            }
        }
        catch (Exception ex)
        {
            // En cas d'erreur imprévue, renvoyer un message d'erreur
            return ($"Erreur de calcul : {ex.Message}", "");
        }
    }


}
