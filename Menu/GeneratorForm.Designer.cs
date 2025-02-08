namespace Menu
{
    partial class GeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataPreview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.chkAdvancedMode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonfermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue dans le generateur de fichier!!!";
            // 
            // dataPreview
            // 
            this.dataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreview.Location = new System.Drawing.Point(610, 62);
            this.dataPreview.Name = "dataPreview";
            this.dataPreview.RowHeadersWidth = 62;
            this.dataPreview.RowTemplate.Height = 28;
            this.dataPreview.Size = new System.Drawing.Size(620, 724);
            this.dataPreview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrez le nombre de lignes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(326, 353);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(264, 26);
            this.txtNumberOfRows.TabIndex = 4;
            this.txtNumberOfRows.TextChanged += new System.EventHandler(this.txtNumberOfRows_TextChanged);
            // 
            // chkAdvancedMode
            // 
            this.chkAdvancedMode.AutoSize = true;
            this.chkAdvancedMode.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdvancedMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkAdvancedMode.Location = new System.Drawing.Point(21, 549);
            this.chkAdvancedMode.Name = "chkAdvancedMode";
            this.chkAdvancedMode.Size = new System.Drawing.Size(258, 29);
            this.chkAdvancedMode.TabIndex = 5;
            this.chkAdvancedMode.Text = "Activer le mode avancé";
            this.chkAdvancedMode.UseVisualStyleBackColor = true;
            this.chkAdvancedMode.CheckedChanged += new System.EventHandler(this.chkAdvancedMode_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modification du nom par defaut:";
            this.label3.Visible = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(326, 423);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(264, 26);
            this.txtFileName.TabIndex = 7;
            this.txtFileName.Visible = false;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intervalle de generation";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min:";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(265, 688);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max:";
            this.label6.Visible = false;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(92, 687);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(82, 26);
            this.txtMin.TabIndex = 11;
            this.txtMin.Visible = false;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(345, 689);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(82, 26);
            this.txtMax.TabIndex = 12;
            this.txtMax.Visible = false;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(16, 751);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(205, 52);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Générer";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonfermer
            // 
            this.buttonfermer.BackColor = System.Drawing.Color.Red;
            this.buttonfermer.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfermer.Location = new System.Drawing.Point(315, 751);
            this.buttonfermer.Name = "buttonfermer";
            this.buttonfermer.Size = new System.Drawing.Size(205, 52);
            this.buttonfermer.TabIndex = 14;
            this.buttonfermer.Text = "Fermer";
            this.buttonfermer.UseVisualStyleBackColor = false;
            this.buttonfermer.Click += new System.EventHandler(this.buttonfermer_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 296);
            this.panel1.TabIndex = 17;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1267, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonfermer);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAdvancedMode);
            this.Controls.Add(this.txtNumberOfRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPreview);
            this.Controls.Add(this.label1);
            this.Name = "GeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator App";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.CheckBox chkAdvancedMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonfermer;
        private System.Windows.Forms.Panel panel1;
    }
}