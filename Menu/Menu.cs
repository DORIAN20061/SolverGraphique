using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        private bool isHoveringGenerator = false; // Effet de survol pour le bouton Generator
        private bool isHoveringResolver = false;  // Effet de survol pour le bouton Resolver

        public Menu()
        {
            InitializeComponent();

            // Associer les événements Paint, MouseEnter et MouseLeave pour btnGenerator
            btnGenerator.Paint += new PaintEventHandler(btnGenerator_Paint);
            btnGenerator.MouseEnter += (s, e) => { isHoveringGenerator = true; btnGenerator.Invalidate(); };
            btnGenerator.MouseLeave += (s, e) => { isHoveringGenerator = false; btnGenerator.Invalidate(); };

            // Associer les événements Paint, MouseEnter et MouseLeave pour btnResolver
            btnResolver.Paint += new PaintEventHandler(btnResolver_Paint);
            btnResolver.MouseEnter += (s, e) => { isHoveringResolver = true; btnResolver.Invalidate(); };
            btnResolver.MouseLeave += (s, e) => { isHoveringResolver = false; btnResolver.Invalidate(); };
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Any initialization code goes here, if needed
        }


        private void btnGenerator_Paint(object sender, PaintEventArgs e)
        {
            CustomizeButton(e, btnGenerator, isHoveringGenerator);
        }

        private void btnResolver_Paint(object sender, PaintEventArgs e)
        {
            CustomizeButton(e, btnResolver, isHoveringResolver);
        }

        private void CustomizeButton(PaintEventArgs e, Button btn, bool isHovering)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 30; // Rayon pour des coins arrondis plus prononcés
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

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            GeneratorForm generatorForm = new GeneratorForm();
            generatorForm.Show();
            this.Hide();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            ResolverForm resolverForm = new ResolverForm();
            resolverForm.Show();
            this.Hide();
        }
    }
}
