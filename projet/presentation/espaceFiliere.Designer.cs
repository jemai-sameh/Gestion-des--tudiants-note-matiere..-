namespace projet.application
{
    partial class espaceFiliere
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
            this.label1 = new System.Windows.Forms.Label();
            this.abriviation = new System.Windows.Forms.TextBox();
            this.nomFiliere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmatiere = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.rech = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abriviation);
            this.groupBox1.Controls.Add(this.nomFiliere);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblmatiere);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(381, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filiere";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(159, 86);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(139, 26);
            this.id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "id Filiere";
            // 
            // abriviation
            // 
            this.abriviation.Location = new System.Drawing.Point(159, 201);
            this.abriviation.Name = "abriviation";
            this.abriviation.Size = new System.Drawing.Size(139, 26);
            this.abriviation.TabIndex = 4;
            // 
            // nomFiliere
            // 
            this.nomFiliere.Location = new System.Drawing.Point(159, 145);
            this.nomFiliere.Name = "nomFiliere";
            this.nomFiliere.Size = new System.Drawing.Size(139, 26);
            this.nomFiliere.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abriviation";
            // 
            // lblmatiere
            // 
            this.lblmatiere.AutoSize = true;
            this.lblmatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatiere.Location = new System.Drawing.Point(51, 145);
            this.lblmatiere.Name = "lblmatiere";
            this.lblmatiere.Size = new System.Drawing.Size(97, 20);
            this.lblmatiere.TabIndex = 0;
            this.lblmatiere.Text = "nom Filiere";
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(245, 379);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(88, 36);
            this.modifier.TabIndex = 63;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click_1);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(123, 435);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(88, 36);
            this.supprimer.TabIndex = 62;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click_1);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(339, 406);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(88, 36);
            this.annuler.TabIndex = 61;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(124, 379);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(88, 36);
            this.ajout.TabIndex = 60;
            this.ajout.Text = "Ajout";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // rech
            // 
            this.rech.Location = new System.Drawing.Point(626, 60);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(189, 20);
            this.rech.TabIndex = 71;
            this.rech.Text = "entrée abriviation";
            this.rech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rech.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(496, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(337, 315);
            this.dataGridView.TabIndex = 69;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(245, 432);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(88, 39);
            this.Enregistrer.TabIndex = 81;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(867, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 74);
            this.button1.TabIndex = 82;
            this.button1.Text = "Ajouter Matiere a la filiere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 60);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Abriviation   :";
            // 
            // espaceFiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.Annotation_2020_05_27_110214;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.rech);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "espaceFiliere";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filiere";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.espaceFiliere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox abriviation;
        private System.Windows.Forms.TextBox nomFiliere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmatiere;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}