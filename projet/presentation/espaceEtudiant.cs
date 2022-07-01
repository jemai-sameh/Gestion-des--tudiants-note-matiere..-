using projet.DAO;
using projet.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.presentation
{
    public partial class espaceEtudiant : Form
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();

        public espaceEtudiant()
        {
            InitializeComponent();
        }


        private void RechCin_TextChanged(object sender, EventArgs e)
        {

            singlotonConnection.Lire("select* from etudiant where nom like '%" + rech.Text + "%'", "etudiant");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["etudiant"];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            if (ligne >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[ligne];
                id.Text = row.Cells["id_etudiant"].Value.ToString();
                cin.Text = row.Cells["cin"].Value.ToString();
                nom.Text = row.Cells["nom"].Value.ToString();
                prenom.Text = row.Cells["prenom"].Value.ToString();
                adresse.Text = row.Cells["adresse"].Value.ToString();
                date.Text = row.Cells["date_naissance"].Value.ToString();
                telephone.Text = row.Cells["telephone"].Value.ToString();
                login.Text = row.Cells["login"].Value.ToString();
                password.Text = row.Cells["motpasse"].Value.ToString();
                if (row.Cells["sexe"].Value.ToString() == "femme")
                {
                    femme.Checked = true;
                }
                else
                {
                    homme.Checked = true;
                }
                cmbFiliere.SelectedItem = new MetierFiliere().GetFiliere("select * from filiere where id_filiere="+int.Parse(row.Cells["id_filiere"].Value.ToString())).Nom_filiere;
                cmbNiveau.SelectedItem =new MetierEtudiant().GetEtudiant("select * from etudiant where id_etudiant="+uint.Parse(row.Cells["id_etudiant"].Value.ToString())).Niveau;
            }

        }

        bool Verifint(String a)
        {
            int entier;
            bool a1 = int.TryParse(a, out entier);
            if (a1 == false)
            {
                MessageBox.Show("doit contenir des entier de 32 bit");
                return false;
            }
            return true;

        }
        private void ajout_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || cin.Text == "" || nom.Text == "" || prenom.Text == "" || telephone.Text == "" || date.Text == "" || adresse.Text == "" || password.Text == "" || login.Text == "" || cmbFiliere.SelectedIndex == -1 || cmbNiveau.SelectedIndex == -1)
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            if (Verifint(id.Text) && Verifint(cin.Text) && Verifint(telephone.Text))
            {
                if (cin.Text.Length == 8 && telephone.Text.Length == 8)
                {
                    singlotonConnection.Ligne = singlotonConnection.Ds.Tables["etudiant"].NewRow();
                    singlotonConnection.Ligne["id_etudiant"] = int.Parse(id.Text);
                    singlotonConnection.Ligne["cin"] = int.Parse(cin.Text);
                    singlotonConnection.Ligne["nom"] = nom.Text;
                    singlotonConnection.Ligne["prenom"] = prenom.Text;
                    singlotonConnection.Ligne["telephone"] = int.Parse(telephone.Text);
                    singlotonConnection.Ligne["adresse"] = adresse.Text;
                    singlotonConnection.Ligne["date_naissance"] = date.Text;
                    if (femme.Checked)
                    {
                        singlotonConnection.Ligne["sexe"] = "femme";
                    }
                    else
                    {
                        singlotonConnection.Ligne["sexe"] = "homme";
                    }


                    singlotonConnection.Ligne["login"] = login.Text;
                    singlotonConnection.Ligne["motpasse"] = password.Text;
                    singlotonConnection.Ligne["niveau"] = cmbNiveau.SelectedItem.ToString();
                    singlotonConnection.Ligne["id_filiere"] = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbFiliere.SelectedItem.ToString() + "'").Id_filiere;


                    for (int i = 0; i < singlotonConnection.Ds.Tables["etudiant"].Rows.Count; i++)
                    {
                        if (id.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["id_etudiant"].ToString() || cin.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["cin"].ToString() || login.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["login"].ToString())
                        {
                            MessageBox.Show("etudiant existe déja");
                            return;
                        }
                    }
                    singlotonConnection.Ds.Tables["etudiant"].Rows.Add(singlotonConnection.Ligne);
                    MessageBox.Show("etudiant ajouter avec succes");
                    dataGridView.DataSource = singlotonConnection.Ds.Tables["etudiant"];
                }
                else
                {
                    MessageBox.Show("cin ou telephone nom valide");
                }
            }
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

        private void modifier_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || cin.Text == "" || nom.Text == "" || prenom.Text == "" || telephone.Text == "" || date.Text == "" || adresse.Text == "" || password.Text == "" || login.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool tr = false;
            if (Verifint(id.Text) && Verifint(cin.Text) && Verifint(telephone.Text))
            {
                if (cin.Text.Length == 8 && telephone.Text.Length == 8)
                {
                    for (int i = 0; i < singlotonConnection.Ds.Tables["etudiant"].Rows.Count; i++)
                    {
                        if (cin.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["cin"].ToString())
                        {
                            tr = true;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["nom"] = nom.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["prenom"] = prenom.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["date_naissance"] = date.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["adresse"] = adresse.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["login"] = login.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["motpasse"] = password.Text;
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["telephone"] = telephone.Text;
                            if (femme.Checked)
                            {
                                singlotonConnection.Ds.Tables["etudiant"].Rows[i]["sexe"] = "femme";

                            }
                            else
                            {
                                singlotonConnection.Ds.Tables["etudiant"].Rows[i]["sexe"] = "homme";

                            }
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["niveau"] = cmbNiveau.SelectedItem.ToString();
                            singlotonConnection.Ds.Tables["etudiant"].Rows[i]["id_filiere"] = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbFiliere.SelectedItem.ToString() + "'").Id_filiere;


                            MessageBox.Show("etudiant modifier déja");
                            dataGridView.DataSource = singlotonConnection.Ds.Tables["etudiant"];
                            return;

                        }
                    }
                
                }
                else
                {
                    MessageBox.Show("cin ou telephone nom valide");
                    return;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("etudiant n'existe pas");
                return;
            }

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
                singlotonConnection.Da.Update(singlotonConnection.Ds, "etudiant");
                MessageBox.Show(" enregistrer ");

            }
            catch (SqlException e2)
            {
                MessageBox.Show("erreur d'enregistrement");

            }

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

            if (id.Text == "" || cin.Text == "" || login.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool tr = false;
            if (Verifint(id.Text) && Verifint(cin.Text) && Verifint(telephone.Text))
            {
                if (cin.Text.Length == 8 && telephone.Text.Length == 8)
                {
                    for (int i = 0; i < singlotonConnection.Ds.Tables["etudiant"].Rows.Count; i++)
                    {
                        if (id.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["id_etudiant"].ToString() || cin.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["cin"].ToString() || login.Text == singlotonConnection.Ds.Tables["etudiant"].Rows[i]["login"].ToString())
                        {
                            tr = true;
                            if (MessageBox.Show("Voulez vous supprimer l'etudiant?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                singlotonConnection.Ds.Tables["etudiant"].Rows[i].Delete();
                                MessageBox.Show("etudiant supprimer déja");
                                dataGridView.DataSource = singlotonConnection.Ds.Tables["etudiant"];
                                break;
                            }
                        }
                    }
                    if (tr == false)
                    {
                        MessageBox.Show("etudiant n'existe pas");
                    }
                }
                else
                {
                    MessageBox.Show("cin non valide");
                }
            }
        }

        private void etud_Load(object sender, EventArgs e)
        {
            singlotonConnection.CONNECTER();

            singlotonConnection.Lire("select * from filiere ", "filiere");
            for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
            {
                cmbFiliere.Items.Add(singlotonConnection.Ds.Tables["filiere"].Rows[i]["nom_filiere"].ToString());

            }

            singlotonConnection.Lire("select * from etudiant", "etudiant");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["etudiant"];
        }
    }
}
