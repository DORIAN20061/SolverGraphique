using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    public partial class GeneratorForm : Form
    {
        private bool isHovering = false; // Variable pour l'effet de survol

        public GeneratorForm()
        {
            InitializeComponent();

            // Associer l'événement Paint pour un style personnalisé de btnGenerate
            btnGenerate.Paint += new PaintEventHandler(btnGenerate_Paint);
            btnGenerate.MouseEnter += (s, e) => { isHovering = true; btnGenerate.Invalidate(); };
            btnGenerate.MouseLeave += (s, e) => { isHovering = false; btnGenerate.Invalidate(); };
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Initialization code can go here, if needed
        }


        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            // Initialization code can go here, if needed
        }


        private void txtNumberOfRows_TextChanged(object sender, EventArgs e)
        {
            // Exemple de code pour valider l'entrée utilisateur
            if (!int.TryParse(txtNumberOfRows.Text, out _))
            {
                errorProvider.SetError(txtNumberOfRows, "Veuillez entrer un nombre valide.");
            }
            else
            {
                errorProvider.SetError(txtNumberOfRows, string.Empty); // Clear any previous error
            }
        }


        private void btnGenerate_Paint(object sender, PaintEventArgs e)
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

        private void chkAdvancedMode_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkAdvancedMode.Checked;
            txtMin.Visible = isChecked;
            txtMax.Visible = isChecked;
            txtFileName.Visible = isChecked;
            label3.Visible = isChecked;
            label4.Visible = isChecked;
            label5.Visible = isChecked;
            label6.Visible = isChecked;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numberOfRows;
            int minValue = -100, maxValue = 100;
            string fileName = "liste.csv"; // Nom de fichier par défaut

            // Réinitialiser l'ErrorProvider
            errorProvider.Clear();

            try
            {
                if (!int.TryParse(txtNumberOfRows.Text, out numberOfRows) || numberOfRows <= 0 || numberOfRows >= 100)
                {
                    throw new ArgumentException("Veuillez entrer un nombre valide et inférieur à 100 pour le nombre de lignes.");
                }

                if (chkAdvancedMode.Checked)
                {
                    minValue = int.Parse(txtMin.Text);
                    maxValue = int.Parse(txtMax.Text);

                    if (minValue < -500 || maxValue > 500 || minValue >= maxValue)
                    {
                        throw new ArgumentOutOfRangeException("L'intervalle doit être entre -500 et 500, avec min < max.");
                    }

                    if (!string.IsNullOrWhiteSpace(txtFileName.Text))
                    {
                        fileName = txtFileName.Text.EndsWith(".csv") ? txtFileName.Text : txtFileName.Text + ".csv";
                    }
                    else
                    {
                        throw new ArgumentException("Veuillez entrer un nom de fichier valide.");
                    }
                }

                Random rand = new Random();
                var data = new List<(int a, int b, int c)>();

                for (int i = 0; i < numberOfRows; i++)
                {
                    int a = rand.Next(minValue, maxValue + 1);
                    int b = rand.Next(minValue, maxValue + 1);
                    int c = rand.Next(minValue, maxValue + 1);
                    data.Add((a, b, c));
                }

                dataPreview.DataSource = data.Select(d => new { d.a, d.b, d.c }).ToList();

                using (var writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("a,b,c");
                    foreach (var (a, b, c) in data)
                    {
                        writer.WriteLine($"{a},{b},{c}");
                    }
                }

                MessageBox.Show($"Fichier {fileName} généré avec succès.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                errorProvider.SetError(txtMin, ex.Message);
                errorProvider.SetError(txtMax, ex.Message);
            }
            catch (ArgumentException ex)
            {
                errorProvider.SetError(txtNumberOfRows, ex.Message);
            }
            catch (FormatException)
            {
                errorProvider.SetError(txtMin, "Veuillez entrer des valeurs numériques pour les champs min et max.");
                errorProvider.SetError(txtMax, "Veuillez entrer des valeurs numériques pour les champs min et max.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur inattendue s'est produite : " + ex.Message);
            }
        }

        private void buttonfermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
