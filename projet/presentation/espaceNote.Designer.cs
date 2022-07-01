namespace projet.application
{
    partial class espaceNote
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
            this.rech = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cmbfiliere = new System.Windows.Forms.ComboBox();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panelds = new System.Windows.Forms.Panel();
            this.lblds1 = new System.Windows.Forms.Label();
            this.lblds2 = new System.Windows.Forms.Label();
            this.ds1 = new System.Windows.Forms.TextBox();
            this.ds2 = new System.Windows.Forms.TextBox();
            this.panelexamen = new System.Windows.Forms.Panel();
            this.lblExamen = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.examen = new System.Windows.Forms.TextBox();
            this.TP = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orale = new System.Windows.Forms.TextBox();
            this.lblOrale = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.modif = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.cmbetudiant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.panelds.SuspendLayout();
            this.panelexamen.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rech
            // 
            this.rech.Location = new System.Drawing.Point(714, 61);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(189, 20);
            this.rech.TabIndex = 71;
            this.rech.Text = "entrée Id etudiant";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(510, 88);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(466, 344);
            this.dataGridView.TabIndex = 69;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // cmbfiliere
            // 
            this.cmbfiliere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiliere.FormattingEnabled = true;
            this.cmbfiliere.Location = new System.Drawing.Point(84, 61);
            this.cmbfiliere.Name = "cmbfiliere";
            this.cmbfiliere.Size = new System.Drawing.Size(121, 21);
            this.cmbfiliere.TabIndex = 72;
            this.cmbfiliere.SelectedIndexChanged += new System.EventHandler(this.cmbfiliere_SelectedIndexChanged);
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(248, 61);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(121, 21);
            this.cmbMatiere.TabIndex = 73;
            this.cmbMatiere.SelectedIndexChanged += new System.EventHandler(this.cmbMatiere_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panelds);
            this.panel.Controls.Add(this.panelexamen);
            this.panel.Controls.Add(this.id);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.orale);
            this.panel.Controls.Add(this.lblOrale);
            this.panel.Location = new System.Drawing.Point(6, 19);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(362, 310);
            this.panel.TabIndex = 74;
            // 
            // panelds
            // 
            this.panelds.Controls.Add(this.lblds1);
            this.panelds.Controls.Add(this.lblds2);
            this.panelds.Controls.Add(this.ds1);
            this.panelds.Controls.Add(this.ds2);
            this.panelds.Location = new System.Drawing.Point(30, 161);
            this.panelds.Name = "panelds";
            this.panelds.Size = new System.Drawing.Size(296, 88);
            this.panelds.TabIndex = 76;
            // 
            // lblds1
            // 
            this.lblds1.AutoSize = true;
            this.lblds1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblds1.Location = new System.Drawing.Point(3, 10);
            this.lblds1.Name = "lblds1";
            this.lblds1.Size = new System.Drawing.Size(37, 24);
            this.lblds1.TabIndex = 4;
            this.lblds1.Text = "DS";
            // 
            // lblds2
            // 
            this.lblds2.AutoSize = true;
            this.lblds2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblds2.Location = new System.Drawing.Point(3, 51);
            this.lblds2.Name = "lblds2";
            this.lblds2.Size = new System.Drawing.Size(48, 24);
            this.lblds2.TabIndex = 5;
            this.lblds2.Text = "DS2";
            // 
            // ds1
            // 
            this.ds1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds1.Location = new System.Drawing.Point(129, 5);
            this.ds1.Name = "ds1";
            this.ds1.Size = new System.Drawing.Size(166, 29);
            this.ds1.TabIndex = 6;
            // 
            // ds2
            // 
            this.ds2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds2.Location = new System.Drawing.Point(128, 48);
            this.ds2.Name = "ds2";
            this.ds2.Size = new System.Drawing.Size(166, 29);
            this.ds2.TabIndex = 7;
            // 
            // panelexamen
            // 
            this.panelexamen.Controls.Add(this.lblExamen);
            this.panelexamen.Controls.Add(this.lblTP);
            this.panelexamen.Controls.Add(this.examen);
            this.panelexamen.Controls.Add(this.TP);
            this.panelexamen.Location = new System.Drawing.Point(29, 74);
            this.panelexamen.Name = "panelexamen";
            this.panelexamen.Size = new System.Drawing.Size(297, 88);
            this.panelexamen.TabIndex = 82;
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamen.Location = new System.Drawing.Point(3, 9);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(87, 24);
            this.lblExamen.TabIndex = 0;
            this.lblExamen.Text = "Examen";
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.Location = new System.Drawing.Point(3, 52);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(36, 24);
            this.lblTP.TabIndex = 1;
            this.lblTP.Text = "TP";
            // 
            // examen
            // 
            this.examen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examen.Location = new System.Drawing.Point(129, 3);
            this.examen.Name = "examen";
            this.examen.Size = new System.Drawing.Size(166, 29);
            this.examen.TabIndex = 2;
            // 
            // TP
            // 
            this.TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP.Location = new System.Drawing.Point(130, 49);
            this.TP.Name = "TP";
            this.TP.Size = new System.Drawing.Size(166, 29);
            this.TP.TabIndex = 3;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(160, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(166, 29);
            this.id.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(35, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 80;
            this.label5.Text = "Id";
            // 
            // orale
            // 
            this.orale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orale.Location = new System.Drawing.Point(158, 252);
            this.orale.Name = "orale";
            this.orale.Size = new System.Drawing.Size(166, 29);
            this.orale.TabIndex = 11;
            // 
            // lblOrale
            // 
            this.lblOrale.AutoSize = true;
            this.lblOrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrale.Location = new System.Drawing.Point(35, 252);
            this.lblOrale.Name = "lblOrale";
            this.lblOrale.Size = new System.Drawing.Size(61, 24);
            this.lblOrale.TabIndex = 9;
            this.lblOrale.Text = "Orale";
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(416, 343);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(88, 30);
            this.Enregistrer.TabIndex = 79;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(416, 222);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(88, 36);
            this.modif.TabIndex = 78;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(416, 285);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(88, 36);
            this.annuler.TabIndex = 76;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(416, 157);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(88, 36);
            this.ajout.TabIndex = 75;
            this.ajout.Text = "Ajout";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // cmbetudiant
            // 
            this.cmbetudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbetudiant.FormattingEnabled = true;
            this.cmbetudiant.Location = new System.Drawing.Point(168, 101);
            this.cmbetudiant.Name = "cmbetudiant";
            this.cmbetudiant.Size = new System.Drawing.Size(121, 21);
            this.cmbetudiant.TabIndex = 75;
            this.cmbetudiant.SelectedIndexChanged += new System.EventHandler(this.cmbetudiant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 80;
            this.label1.Text = "Id Etudiant :";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(40, 158);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(370, 310);
            this.groupBox.TabIndex = 81;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Note";
            this.groupBox.Visible = false;
            // 
            // espaceNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.Annotation_2020_05_27_110214;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbetudiant);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.cmbfiliere);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.rech);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "espaceNote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "note";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.espaceNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelds.ResumeLayout(false);
            this.panelds.PerformLayout();
            this.panelexamen.ResumeLayout(false);
            this.panelexamen.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmbfiliere;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox TP;
        private System.Windows.Forms.TextBox examen;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.TextBox orale;
        private System.Windows.Forms.Label lblOrale;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbetudiant;
        private System.Windows.Forms.Panel panelexamen;
        private System.Windows.Forms.Panel panelds;
        private System.Windows.Forms.Label lblds1;
        private System.Windows.Forms.Label lblds2;
        private System.Windows.Forms.TextBox ds1;
        private System.Windows.Forms.TextBox ds2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
    }
}