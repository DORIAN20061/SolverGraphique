namespace Menu
{
    partial class ResolverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResolverForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataPreview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkCustomFileName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtCustomFileName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbFilterSolutions = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonfermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(427, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nous Allons Résoudre Des équations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataPreview
            // 
            this.dataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreview.Location = new System.Drawing.Point(734, 134);
            this.dataPreview.Name = "dataPreview";
            this.dataPreview.RowHeadersWidth = 62;
            this.dataPreview.RowTemplate.Height = 28;
            this.dataPreview.Size = new System.Drawing.Size(553, 534);
            this.dataPreview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrez le chemin du fichier:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(272, 465);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(439, 26);
            this.txtFilePath.TabIndex = 4;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(618, 462);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 32);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Parcourir";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkCustomFileName
            // 
            this.chkCustomFileName.AutoSize = true;
            this.chkCustomFileName.BackColor = System.Drawing.Color.DarkCyan;
            this.chkCustomFileName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomFileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkCustomFileName.Location = new System.Drawing.Point(32, 375);
            this.chkCustomFileName.Name = "chkCustomFileName";
            this.chkCustomFileName.Size = new System.Drawing.Size(294, 29);
            this.chkCustomFileName.TabIndex = 6;
            this.chkCustomFileName.Text = "Activation du mode avancé";
            this.chkCustomFileName.UseVisualStyleBackColor = false;
            this.chkCustomFileName.CheckedChanged += new System.EventHandler(this.chkCustomFileName_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Changer le nom du fichier:";
            this.label3.Visible = false;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValidate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(9, 633);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(165, 49);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Resoudre";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtCustomFileName
            // 
            this.txtCustomFileName.Location = new System.Drawing.Point(275, 574);
            this.txtCustomFileName.Name = "txtCustomFileName";
            this.txtCustomFileName.Size = new System.Drawing.Size(441, 26);
            this.txtCustomFileName.TabIndex = 10;
            this.txtCustomFileName.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbFilterSolutions
            // 
            this.cmbFilterSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterSolutions.FormattingEnabled = true;
            this.cmbFilterSolutions.Location = new System.Drawing.Point(1052, 95);
            this.cmbFilterSolutions.Name = "cmbFilterSolutions";
            this.cmbFilterSolutions.Size = new System.Drawing.Size(213, 30);
            this.cmbFilterSolutions.TabIndex = 11;
            this.cmbFilterSolutions.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(734, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filtrage des solutions par type:";
            this.label4.Visible = false;
            // 
            // buttonfermer
            // 
            this.buttonfermer.BackColor = System.Drawing.Color.Red;
            this.buttonfermer.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfermer.Location = new System.Drawing.Point(263, 633);
            this.buttonfermer.Name = "buttonfermer";
            this.buttonfermer.Size = new System.Drawing.Size(205, 52);
            this.buttonfermer.TabIndex = 15;
            this.buttonfermer.Text = "Fermer";
            this.buttonfermer.UseVisualStyleBackColor = false;
            this.buttonfermer.Click += new System.EventHandler(this.buttonfermer_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(45, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 296);
            this.panel1.TabIndex = 16;
            // 
            // ResolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1311, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonfermer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFilterSolutions);
            this.Controls.Add(this.txtCustomFileName);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCustomFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPreview);
            this.Controls.Add(this.label1);
            this.Name = "ResolverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolver App";
            this.Load += new System.EventHandler(this.ResolverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkCustomFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtCustomFileName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbFilterSolutions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonfermer;
        private System.Windows.Forms.Panel panel1;
    }
}