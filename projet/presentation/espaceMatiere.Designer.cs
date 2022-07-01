namespace projet.application
{
    partial class espaceMatiere
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.CheckBox();
            this.cmbCredit = new System.Windows.Forms.ComboBox();
            this.cmbCoef = new System.Windows.Forms.ComboBox();
            this.cmbenseignant = new System.Windows.Forms.ComboBox();
            this.nomMatiere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rech = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ds);
            this.groupBox1.Controls.Add(this.cmbCredit);
            this.groupBox1.Controls.Add(this.cmbCoef);
            this.groupBox1.Controls.Add(this.cmbenseignant);
            this.groupBox1.Controls.Add(this.nomMatiere);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(33, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matiere";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(234, 41);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(166, 31);
            this.id.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(54, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 73;
            this.label5.Text = "Id";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(234, 275);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(67, 33);
            this.ds.TabIndex = 17;
            this.ds.Text = "DS";
            this.ds.UseVisualStyleBackColor = true;
            // 
            // cmbCredit
            // 
            this.cmbCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCredit.FormattingEnabled = true;
            this.cmbCredit.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6",
            "8"});
            this.cmbCredit.Location = new System.Drawing.Point(234, 231);
            this.cmbCredit.Name = "cmbCredit";
            this.cmbCredit.Size = new System.Drawing.Size(166, 33);
            this.cmbCredit.TabIndex = 16;
            // 
            // cmbCoef
            // 
            this.cmbCoef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoef.FormattingEnabled = true;
            this.cmbCoef.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbCoef.Location = new System.Drawing.Point(234, 189);
            this.cmbCoef.Name = "cmbCoef";
            this.cmbCoef.Size = new System.Drawing.Size(166, 33);
            this.cmbCoef.TabIndex = 15;
            // 
            // cmbenseignant
            // 
            this.cmbenseignant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbenseignant.FormattingEnabled = true;
            this.cmbenseignant.Location = new System.Drawing.Point(234, 146);
            this.cmbenseignant.Name = "cmbenseignant";
            this.cmbenseignant.Size = new System.Drawing.Size(166, 33);
            this.cmbenseignant.TabIndex = 14;
            // 
            // nomMatiere
            // 
            this.nomMatiere.Location = new System.Drawing.Point(234, 84);
            this.nomMatiere.Name = "nomMatiere";
            this.nomMatiere.Size = new System.Drawing.Size(166, 31);
            this.nomMatiere.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crédit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Coefficient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enseignant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom matiere";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(503, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(473, 309);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // rech
            // 
            this.rech.Location = new System.Drawing.Point(741, 55);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(162, 20);
            this.rech.TabIndex = 7;
            this.rech.Text = "entrer nom matiere";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.abr_TextChanged);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(222, 392);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(88, 36);
            this.modifier.TabIndex = 63;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(90, 436);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(88, 36);
            this.supprimer.TabIndex = 62;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(210, 436);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(88, 36);
            this.annuler.TabIndex = 61;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(90, 392);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(88, 36);
            this.ajout.TabIndex = 60;
            this.ajout.Text = "Ajout";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(316, 420);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(88, 30);
            this.Enregistrer.TabIndex = 80;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "Nom matiere :";
            // 
            // espaceMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.Annotation_2020_05_27_110214;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.rech);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "espaceMatiere";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "matiere";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.espaceMatiere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ds;
        private System.Windows.Forms.ComboBox cmbCredit;
        private System.Windows.Forms.ComboBox cmbCoef;
        private System.Windows.Forms.ComboBox cmbenseignant;
        private System.Windows.Forms.TextBox nomMatiere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}