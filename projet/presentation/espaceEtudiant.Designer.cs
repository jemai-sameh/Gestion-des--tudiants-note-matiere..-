namespace projet.presentation
{
    partial class espaceEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.rech = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNiveau = new System.Windows.Forms.ComboBox();
            this.cmbFiliere = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.login = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.homme = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.femme = new System.Windows.Forms.RadioButton();
            this.cin = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblcin = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Nom    :";
            // 
            // Enregistrer
            // 
            this.Enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enregistrer.Location = new System.Drawing.Point(346, 411);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(88, 39);
            this.Enregistrer.TabIndex = 90;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // rech
            // 
            this.rech.Location = new System.Drawing.Point(725, 46);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(189, 20);
            this.rech.TabIndex = 89;
            this.rech.Text = "entrée nom";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.RechCin_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cmbNiveau);
            this.panel1.Controls.Add(this.cmbFiliere);
            this.panel1.Controls.Add(this.Niveau);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.telephone);
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.homme);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.femme);
            this.panel1.Controls.Add(this.cin);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.prenom);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblcin);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 296);
            this.panel1.TabIndex = 84;
            // 
            // cmbNiveau
            // 
            this.cmbNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNiveau.FormattingEnabled = true;
            this.cmbNiveau.Items.AddRange(new object[] {
            "1 ere  Licence",
            "2 éme Licence",
            "3 éme Licence",
            "1 ere Master ",
            "2 éme Master",
            "Doctorat"});
            this.cmbNiveau.Location = new System.Drawing.Point(184, 541);
            this.cmbNiveau.Name = "cmbNiveau";
            this.cmbNiveau.Size = new System.Drawing.Size(231, 28);
            this.cmbNiveau.TabIndex = 83;
            // 
            // cmbFiliere
            // 
            this.cmbFiliere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiliere.FormattingEnabled = true;
            this.cmbFiliere.Location = new System.Drawing.Point(184, 484);
            this.cmbFiliere.Name = "cmbFiliere";
            this.cmbFiliere.Size = new System.Drawing.Size(231, 28);
            this.cmbFiliere.TabIndex = 82;
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Niveau.Location = new System.Drawing.Point(17, 537);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(94, 29);
            this.Niveau.TabIndex = 81;
            this.Niveau.Text = "Niveau";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 29);
            this.label14.TabIndex = 80;
            this.label14.Text = "Filiere";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(184, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(231, 26);
            this.id.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(30, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 75;
            this.label5.Text = "Id";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(184, 294);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(231, 26);
            this.date.TabIndex = 63;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(184, 384);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 26);
            this.login.TabIndex = 52;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(184, 250);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(231, 26);
            this.telephone.TabIndex = 62;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(184, 341);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(231, 26);
            this.adresse.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 29);
            this.label12.TabIndex = 61;
            this.label12.Text = "telephone";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(184, 432);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(231, 26);
            this.password.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Date Naissance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mot de passe";
            // 
            // homme
            // 
            this.homme.AutoSize = true;
            this.homme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homme.Location = new System.Drawing.Point(314, 200);
            this.homme.Name = "homme";
            this.homme.Size = new System.Drawing.Size(101, 28);
            this.homme.TabIndex = 59;
            this.homme.TabStop = true;
            this.homme.Text = "Homme";
            this.homme.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "adresse";
            // 
            // femme
            // 
            this.femme.AutoSize = true;
            this.femme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femme.Location = new System.Drawing.Point(184, 200);
            this.femme.Name = "femme";
            this.femme.Size = new System.Drawing.Size(99, 28);
            this.femme.TabIndex = 58;
            this.femme.TabStop = true;
            this.femme.Text = "Femme";
            this.femme.UseVisualStyleBackColor = true;
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(184, 72);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(231, 26);
            this.cin.TabIndex = 57;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(184, 109);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(231, 26);
            this.nom.TabIndex = 56;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(184, 158);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(231, 26);
            this.prenom.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "Sexe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 53;
            this.label11.Text = "Prenom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nom";
            // 
            // lblcin
            // 
            this.lblcin.AutoSize = true;
            this.lblcin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcin.Location = new System.Drawing.Point(18, 64);
            this.lblcin.Name = "lblcin";
            this.lblcin.Size = new System.Drawing.Size(52, 29);
            this.lblcin.TabIndex = 51;
            this.lblcin.Text = "Cin";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(513, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(449, 337);
            this.dataGridView.TabIndex = 83;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modifier
            // 
            this.modifier.Image = global::projet.Properties.Resources.icons8_modifier_l_utilisateur_homme_16;
            this.modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifier.Location = new System.Drawing.Point(219, 386);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(102, 36);
            this.modifier.TabIndex = 88;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Image = global::projet.Properties.Resources.icons8_supprimer_l_utilisateur_homme_16;
            this.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimer.Location = new System.Drawing.Point(83, 437);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(98, 36);
            this.supprimer.TabIndex = 87;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // annuler
            // 
            this.annuler.Image = global::projet.Properties.Resources.icons8_annuler_24;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(219, 437);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(102, 36);
            this.annuler.TabIndex = 86;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajout
            // 
            this.ajout.Image = global::projet.Properties.Resources.icons8_ajouter_un_utilisateur_homme_30;
            this.ajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajout.Location = new System.Drawing.Point(83, 386);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(98, 36);
            this.ajout.TabIndex = 85;
            this.ajout.Text = "Ajout";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 320);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etudiant";
            // 
            // espaceEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.Annotation_2020_05_27_110214;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.rech);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "espaceEtudiant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "etud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.etud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton homme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton femme;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcin;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.ComboBox cmbFiliere;
        private System.Windows.Forms.Label Niveau;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}