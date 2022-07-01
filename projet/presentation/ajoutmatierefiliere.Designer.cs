namespace projet.presentation
{
    partial class ajoutmatierefiliere
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblmatiere = new System.Windows.Forms.Label();
            this.cmbmatiere = new System.Windows.Forms.ComboBox();
            this.cmbfiliere = new System.Windows.Forms.ComboBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matiere";
            // 
            // lblmatiere
            // 
            this.lblmatiere.AutoSize = true;
            this.lblmatiere.Location = new System.Drawing.Point(127, 87);
            this.lblmatiere.Name = "lblmatiere";
            this.lblmatiere.Size = new System.Drawing.Size(57, 13);
            this.lblmatiere.TabIndex = 7;
            this.lblmatiere.Text = "nom Filiere";
            // 
            // cmbmatiere
            // 
            this.cmbmatiere.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmatiere.FormattingEnabled = true;
            this.cmbmatiere.Location = new System.Drawing.Point(219, 151);
            this.cmbmatiere.Name = "cmbmatiere";
            this.cmbmatiere.Size = new System.Drawing.Size(121, 21);
            this.cmbmatiere.TabIndex = 8;
            // 
            // cmbfiliere
            // 
            this.cmbfiliere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiliere.FormattingEnabled = true;
            this.cmbfiliere.Location = new System.Drawing.Point(219, 78);
            this.cmbfiliere.Name = "cmbfiliere";
            this.cmbfiliere.Size = new System.Drawing.Size(121, 21);
            this.cmbfiliere.TabIndex = 9;
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(176, 209);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(88, 39);
            this.Enregistrer.TabIndex = 86;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(12, 118);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(88, 36);
            this.supprimer.TabIndex = 84;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(12, 176);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(88, 36);
            this.annuler.TabIndex = 83;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(12, 58);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(88, 36);
            this.ajout.TabIndex = 82;
            this.ajout.Text = "Ajout";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 190);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ajoutmatierefiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 260);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.cmbfiliere);
            this.Controls.Add(this.cmbmatiere);
            this.Controls.Add(this.lblmatiere);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ajoutmatierefiliere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajoutmatierefiliere";
            this.Load += new System.EventHandler(this.ajoutmatierefiliere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmatiere;
        private System.Windows.Forms.ComboBox cmbmatiere;
        private System.Windows.Forms.ComboBox cmbfiliere;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}