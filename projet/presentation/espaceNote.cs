using projet.DAO;
using projet.Metier;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.application
{
    public partial class espaceNote : Form
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();
        public espaceNote()
        {
            InitializeComponent();
            
        }
     
        private void espaceNote_Load(object sender, EventArgs e)
        {
            singlotonConnection.CONNECTER();
            singlotonConnection.Lire("select * from filiere ", "filiere");
            cmbfiliere.Items.Add("choisir filiere");
            cmbfiliere.SelectedIndex = 0;
            for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
            {
                cmbfiliere.Items.Add(singlotonConnection.Ds.Tables["filiere"].Rows[i]["nom_filiere"].ToString());

            }
            cmbMatiere.Items.Add("choisir matiere");
            cmbMatiere.SelectedIndex = 0;
            cmbetudiant.Items.Add("choisir etudiant");
            cmbetudiant.SelectedIndex = 0;

            //singlotonConnection.Lire("select id_note, cin, nom_matiere, credit, coefficient, note_examen, note_Ds1, note_Ds2, note_Orale, note_tp  FROM matiere, note, etudiant where matiere.id_matiere = note.id_matiere AND etudiant.id_etudiant = note.id_etudiant ", "note");
           singlotonConnection.Lire("select *  FROM note ", "note");

            dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try { 
            singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
            singlotonConnection.Da.Update(singlotonConnection.Ds, "note");
                MessageBox.Show(" enregistrer ");

            }
            catch (SqlException e2)
            {
                MessageBox.Show("erreur d'enregistrement");

            }
            
        }

        bool Verifint(String a)
        {
            int entier;
            bool a1= int.TryParse(a, out entier);
            if (a1 == false)
            {
                MessageBox.Show("doit contenir des entier de 32 bit");
                return false;
            }
            return true;
           
        }
        

        private void ajout_Click(object sender, EventArgs e)
        {
            if (cmbMatiere.SelectedIndex == -1 || cmbMatiere.SelectedItem.Equals("choisir matiere"))
            {
                MessageBox.Show(" Merci de choisir matiere");
                return;
            }
            Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbMatiere.SelectedItem.ToString() + "'");
            singlotonConnection.Ligne = singlotonConnection.Ds.Tables["note"].NewRow();
            if (id.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            if (Verifint(id.Text))
            {
                if (matiere.DS)
                {
                    if (ds1.Text == "" || ds2.Text == "" || orale.Text == "")
                    {
                        MessageBox.Show(" Merci de remplir les champs");
                        return;
                    }
                    else
                    {
                        panelds.Enabled = true;
                        panelexamen.Enabled = false;
                        double ds11, ds22;
                        bool aa1 = double.TryParse(ds1.Text, out ds11);
                        bool a2 = double.TryParse(ds2.Text, out ds22);

                        if (aa1 == false || ds11 < 0 || ds11 > 20 || a2 == false || ds22 < 0 || ds22 > 20)
                        {
                            MessageBox.Show("doit etre de type double et entre 0 et 20");
                            return;

                        }
                        else
                        {

                            singlotonConnection.Ligne["id_note"] = int.Parse(id.Text);
                            singlotonConnection.Ligne["note_Ds1"] = ds11;
                            singlotonConnection.Ligne["note_Ds2"] = ds22;
                        }

                    }
                }
                else
                {
                    if (examen.Text == "" || orale.Text == "")
                    {
                        MessageBox.Show(" Merci de remplir les champs");
                        return;
                    }
                    else
                    {
                        panelds.Enabled = false;
                        panelexamen.Enabled = true;
                        double examenn, tpp;
                        bool a11 = double.TryParse(examen.Text, out examenn);
                        bool a2 = double.TryParse(TP.Text, out tpp);

                        if (a11 == false || examenn < 0 || examenn > 20 || a2 == false || tpp < 0 || tpp > 20)
                        {
                            MessageBox.Show("doit etre de type double et entre 0 et 20");
                            return;

                        }
                        singlotonConnection.Ligne["id_note"] = int.Parse(id.Text);
                        singlotonConnection.Ligne["note_examen"] = examenn;
                        singlotonConnection.Ligne["note_tp"] = tpp;

                    }
                }
                    double oralee;
                    bool a1 = double.TryParse(orale.Text, out oralee);
                    if (a1 == false || oralee < 0 || oralee > 20)
                    {
                        MessageBox.Show("doit etre de type double et entre 0 et 20");
                        return;

                    }
                    singlotonConnection.Ligne["note_Orale"] = oralee;

                    Etudiant etudiant = new MetierEtudiant().GetEtudiant("select * from etudiant where nom='" + cmbetudiant.SelectedItem.ToString() + "'");
                    singlotonConnection.Ligne["id_matiere"] = matiere.Id_matiere;
                    singlotonConnection.Ligne["id_etudiant"] = etudiant.Num_etudiant;
                    for (int i = 0; i < singlotonConnection.Ds.Tables["note"].Rows.Count; i++)
                    {
                        if (id.Text == singlotonConnection.Ds.Tables["note"].Rows[i]["id_note"].ToString())
                        {
                            MessageBox.Show(" existe déja");
                            return;
                        }
                    }
                
            
            singlotonConnection.Ds.Tables["note"].Rows.Add(singlotonConnection.Ligne);
            MessageBox.Show("ajouter note avec succes");
            vide();
            dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];
                return;

            }
        }

        private void modif_Click(object sender, EventArgs e)
        {
            if (cmbMatiere.SelectedIndex == -1 || cmbMatiere.SelectedItem.Equals("choisir matiere"))
            {
                MessageBox.Show(" Merci de choisir matiere");
                return;
            }
            if (cmbetudiant.SelectedIndex == -1 || cmbetudiant.SelectedItem.Equals("choisir etudiant"))
            {
                MessageBox.Show(" Merci de choisir etudiant");
                return;
            }
            Etudiant etudiant = new MetierEtudiant().GetEtudiant("select * from etudiant where nom='" + cmbetudiant.SelectedItem.ToString() + "'");

            Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbMatiere.SelectedItem.ToString() + "'");
            singlotonConnection.Ligne = singlotonConnection.Ds.Tables["note"].NewRow();

            for (int i = 0; i < singlotonConnection.Ds.Tables["note"].Rows.Count; i++)
            {
                if (etudiant.Num_etudiant.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_etudiant"].ToString() || matiere.Id_matiere.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_matiere"].ToString())
                {
                   

                        if (matiere.DS)
                        {
                            if ( ds1.Text == "" || ds2.Text == "" || orale.Text == "")
                            {
                                MessageBox.Show(" Merci de remplir les champs");
                                return;
                            }
                            else
                            {
                                double ds11, ds22;
                                bool a1 = double.TryParse(ds1.Text, out ds11);
                                bool a2 = double.TryParse(ds2.Text, out ds22);

                                if (a1 == false || ds11 < 0 || ds11 > 20 || a2 == false || ds22 < 0 || ds22 > 20)
                                {
                                    MessageBox.Show("doit etre de type double et entre 0 et 20");
                                    return;

                                }
                                singlotonConnection.Ds.Tables["note"].Rows[i]["note_Ds1"] = ds11;
                                singlotonConnection.Ds.Tables["note"].Rows[i]["note_Ds2"] = ds22;

                            }
                        }
                        else
                        {
                            if ( examen.Text == "" || orale.Text == "")
                            {
                                MessageBox.Show(" Merci de remplir les champs");
                                return;
                            }
                            else
                            {
                                panelds.Enabled = false;
                                panelexamen.Enabled = true;
                                double examenn, tpp;
                                bool a11 = double.TryParse(examen.Text, out examenn);
                                bool a2 = double.TryParse(TP.Text, out tpp);

                                if (a11 == false || examenn < 0 || examenn > 20 || a2 == false || tpp < 0 || tpp > 20)
                                {
                                    MessageBox.Show("doit etre de type double et entre 0 et 20");
                                    return;

                                }
                                singlotonConnection.Ds.Tables["note"].Rows[i]["note_examen"] = examenn;
                                singlotonConnection.Ds.Tables["note"].Rows[i]["note_tp"] = tpp;

                            }

                        }
                    }
                   
                    double oralee;
                    bool a111 = double.TryParse(orale.Text, out oralee);

                    if (a111 == false || oralee < 0 || oralee > 20)
                    {
                        MessageBox.Show("doit etre de type double et entre 0 et 20");
                        return;

                    }
                    singlotonConnection.Ds.Tables["note"].Rows[i]["note_Orale"] = oralee;

                    MessageBox.Show("modification avec succes");
                    vide();
                    dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];
                    return;

                }
                MessageBox.Show("pour l'etudiant " + cmbetudiant.SelectedItem.ToString() + " il n'ya pas un note en matiere (" + cmbMatiere.SelectedItem.ToString() + ")");
            
        }
        void vide()
        {
            id.Text = "";
            examen.Text = "";
            TP.Text = "";
            ds1.Text = "";
            ds2.Text = "";
            orale.Text = "";
            panelds.Enabled = false;
            panelexamen.Enabled = false;
            groupBox.Visible = false;


        }
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.GetType() == typeof(ComboBox))
                {
                    ct.ResetText();
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }
        private void annuler_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous vider les champs?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void cmbfiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbfiliere.SelectedItem.Equals("choisir filiere"))
            {
                if (cmbfiliere.SelectedIndex != -1)
                {
                    Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbfiliere.SelectedItem.ToString() + "'");
                    singlotonConnection.Lire("select * from filiere_matiere where id_filiere =" + filiere.Id_filiere, "filiere_matiere");
                    cmbMatiere.Items.Clear();
                    cmbMatiere.Items.Add("choisir matiere");
                    cmbMatiere.SelectedIndex = 0;

                    for (int i = 0; i < singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Count; i++)
                    {
                        Matiere matiere = new MetierMatiere().getMatiere("Select * from matiere where id_matiere=" + int.Parse(singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id_matiere"].ToString()));

                        cmbMatiere.Items.Add(matiere.Nom_matiere);

                    }
                    singlotonConnection.Lire("select * from etudiant where id_filiere = " + filiere.Id_filiere, "etudiant");
                    cmbetudiant.Items.Clear();
                    cmbetudiant.Items.Add("choisir etudiant");
                    cmbetudiant.SelectedIndex = 0;
                    for (int i = 0; i < singlotonConnection.Ds.Tables["etudiant"].Rows.Count; i++)
                    {
                        cmbetudiant.Items.Add(singlotonConnection.Ds.Tables["etudiant"].Rows[i]["nom"].ToString());

                    }
                    if (singlotonConnection.Ds.Tables["note"] != null)
                    {
                        singlotonConnection.Ds.Tables["note"].Clear();
                    }
                    //singlotonConnection.Lire("select id_note, cin, nom_matiere, credit, coefficient, note_examen, note_Ds1, note_Ds2, note_Orale, note_tp  FROM matiere, note, etudiant where matiere.id_matiere = note.id_matiere AND etudiant.id_etudiant = note.id_etudiant  AND  etudiant.id_filiere =" + filiere.Id_filiere, "note");
                    //singlotonConnection.Lire("select id_note, cin, nom_matiere, credit, coefficient, note_examen, note_Ds1, note_Ds2, note_Orale, note_tp  FROM matiere, note, etudiant where matiere.id_matiere = note.id_matiere AND etudiant.id_etudiant = note.id_etudiant  AND  etudiant.id_filiere =" + filiere.Id_filiere, "note");
                    singlotonConnection.Lire("select *  FROM note ", "note");
                    dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];


                }
            }
        }

        void verif()
        {

            vide();

            if (!cmbMatiere.SelectedItem.Equals("choisir matiere")){
                if (!cmbetudiant.SelectedItem.Equals("choisir etudiant"))
                {
                    
                        Etudiant etudiant = new MetierEtudiant().GetEtudiant("select * from etudiant where nom='" + cmbetudiant.SelectedItem.ToString() + "'");
                        Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbMatiere.SelectedItem.ToString() + "'");
                        if (matiere.DS) {
                        panelds.Enabled = true;

                    } else
                        {
                        panelexamen.Enabled = true;
                    }
                        for (int i = 0; i < singlotonConnection.Ds.Tables["note"].Rows.Count; i++)
                        {
                        if (etudiant.Num_etudiant.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_etudiant"].ToString() && matiere.Id_matiere.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_matiere"].ToString())
                        {
                            if (matiere.DS)
                            {
                                ds1.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["note_Ds1"].ToString();
                                ds2.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["note_Ds2"].ToString();
                            }

                            else
                            {
                                examen.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["note_examen"].ToString();
                                TP.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["note_tp"].ToString();


                            }
                            id.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["id_note"].ToString();
                            orale.Text = singlotonConnection.Ds.Tables["note"].Rows[i]["note_Orale"].ToString();
                        }
                            

                        }
                        panel.Visible = true;
                    groupBox.Visible = true;


                    
                }
            }
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int ligne = e.RowIndex;
            if (ligne >= 0)
            {
                
                        DataGridViewRow row = this.dataGridView.Rows[ligne];

                        Etudiant etudiant = new MetierEtudiant().GetEtudiant("select * from etudiant where id_etudiant=" + int.Parse(row.Cells["id_etudiant"].Value.ToString()) );
                    Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where id_matiere='" + row.Cells["id_matiere"].Value.ToString() + "'");

                    if (matiere.DS) { 
                        panelds.Enabled = true;

                      }
                else
                {
                    panelexamen.Enabled = true;
                }
                for (int i = 0; i < singlotonConnection.Ds.Tables["note"].Rows.Count; i++)
                    {
                        
                           
                            if (etudiant.Num_etudiant.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_etudiant"].ToString() || matiere.Id_matiere.ToString() == singlotonConnection.Ds.Tables["note"].Rows[i]["id_matiere"].ToString())
                            {
                            if (matiere.DS)
                            {
                                ds1.Text = row.Cells["note_Ds1"].Value.ToString();
                                ds2.Text = row.Cells["note_Ds2"].Value.ToString();
                            }
                            else {
                            
                                examen.Text = row.Cells["note_examen"].Value.ToString();
                                TP.Text = row.Cells["note_tp"].Value.ToString();
                                }
                           
                            id.Text = row.Cells["id_note"].Value.ToString();
                            orale.Text = row.Cells["note_Orale"].Value.ToString();
                                cmbetudiant.SelectedItem = etudiant.Nom.ToString();
                                cmbMatiere.SelectedItem = matiere.Nom_matiere.ToString();
                                cmbfiliere.SelectedItem = etudiant.Filiere.ToString();
                                groupBox.Visible = true;   
                            }


                
                
            }}
        }



        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            verif();
            if (!cmbMatiere.SelectedItem.Equals("choisir matiere")) {
                if (!cmbfiliere.SelectedItem.Equals("choisir filiere"))
                {
                    if (cmbfiliere.SelectedIndex != -1 && cmbMatiere.SelectedIndex!=-1)
                    {
                        Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbfiliere.SelectedItem.ToString() + "'");
                        Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbMatiere.SelectedItem.ToString() + "'");
                        if (singlotonConnection.Ds.Tables["note"] != null)
                        {
                            singlotonConnection.Ds.Tables["note"].Clear();
                        }
                        if (matiere.DS)
                        {
                            singlotonConnection.Lire("select * from note where id_matiere=" + matiere.Id_matiere + "and  note_Ds1>10 and note_Ds2>10 ", "note");

                        }
                        else
                        {
                            
                            singlotonConnection.Lire("select * from note  where id_matiere=" + matiere.Id_matiere + "and  note_examen>10", "note");
                        }

                        dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];


                    }
                }
            }

        }

        private void cmbetudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            verif();
        }


        private void cin_TextChanged(object sender, EventArgs e)
        {   if (int.TryParse(rech.Text, out int r))
            {
                singlotonConnection.Lire("select * from note where id_etudiant like '%" + r + "%'", "note");
                dataGridView.DataSource = singlotonConnection.Ds.Tables["note"];
            }
        }
    }
}
