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

namespace projet.application
{
    public partial class espaceEnseignant : Form
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();

        public espaceEnseignant()
        {
            InitializeComponent();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            if (ligne >= 0) 
            {
                DataGridViewRow row = this.dataGridView1.Rows[ligne];
                id.Text = row.Cells["id_enseignant"].Value.ToString();
                cin.Text = row.Cells["cin"].Value.ToString();
                nom.Text = row.Cells["nom"].Value.ToString();
                prenom.Text = row.Cells["prenom"].Value.ToString();
                adresse.Text = row.Cells["adresse"].Value.ToString();
                date.Text = row.Cells["date_naissance"].Value.ToString();
                telephone.Text = row.Cells["telephone"].Value.ToString();
                login.Text = row.Cells["login"].Value.ToString();
                password.Text = row.Cells["motpasse"].Value.ToString();
                if (row.Cells["sexe"].Value.ToString()=="femme")
                {
                    femme.Checked =true;
                }else {
                    homme.Checked = true;
                }
            }

        }

        private void espaceEnseignant_Load(object sender, EventArgs e)
        {

            singlotonConnection.CONNECTER();
            singlotonConnection.Lire("select id_enseignant,cin,nom,prenom,telephone,adresse,date_naissance,sexe,login,motpasse from enseignant", "enseignant");
           // singlotonConnection.Lire("select * from enseignant", "enseignant");
            dataGridView1.DataSource = singlotonConnection.Ds.Tables["enseignant"];

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
                singlotonConnection.Da.Update(singlotonConnection.Ds, "enseignant");
                MessageBox.Show(" enregistrer ");

            }
            catch (SqlException e2)
            {
                MessageBox.Show("erreur d'enregistrement");

            }
        }

        private void ajout_Click(object sender, EventArgs e)
        {
                if (id.Text == "" || cin.Text == "" || nom.Text == "" || prenom.Text == "" || telephone.Text == "" || date.Text == "" || adresse.Text == "" || password.Text == "" || login.Text == "")

                {
                    MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            if (Verifint(id.Text) && Verifint(cin.Text) && Verifint(telephone.Text))
            {
                if (cin.Text.Length == 8 && telephone.Text.Length == 8)
                {
                    singlotonConnection.Ligne = singlotonConnection.Ds.Tables["enseignant"].NewRow();
            singlotonConnection.Ligne[0] = int.Parse(id.Text);
            singlotonConnection.Ligne[1] = int.Parse(cin.Text);
            singlotonConnection.Ligne[2] = nom.Text;
            singlotonConnection.Ligne[3] = prenom.Text;
            singlotonConnection.Ligne[4] = int.Parse(telephone.Text);
            singlotonConnection.Ligne[5] = adresse.Text;
            singlotonConnection.Ligne[6] = date.Text;
            if (femme.Checked)
            {
                singlotonConnection.Ligne[7] = "femme";
            }
            else
            {
                singlotonConnection.Ligne[7] = "homme";
            }
                
               
            singlotonConnection.Ligne[8] = login.Text;
            singlotonConnection.Ligne[9] = password.Text;


            for (int i = 0; i < singlotonConnection.Ds.Tables["enseignant"].Rows.Count; i++)
            {
                if (id.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i][0].ToString()|| cin.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i][1].ToString())
                {
                    MessageBox.Show("enseignant existe déja");
                    return;
                }
            }
            singlotonConnection.Ds.Tables["enseignant"].Rows.Add(singlotonConnection.Ligne);
            MessageBox.Show("enseignant ajouter avec succes");
            dataGridView1.DataSource = singlotonConnection.Ds.Tables["enseignant"];
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
        private void annuler_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous vider les champs?", "Confirmation", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || cin.Text == "" || nom.Text == "" || prenom.Text == "" || telephone.Text == "" || date.Text == "" || adresse.Text == "" || password.Text == "" || login.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            
                bool tr = false;
                for (int i = 0; i < singlotonConnection.Ds.Tables["enseignant"].Rows.Count; i++)
                {
                if (id.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i][0].ToString()||cin.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i][1].ToString())
                {
                    tr = true;
                    if (MessageBox.Show("Voulez vous supprimer l'enseignant?", "Confirmation",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        singlotonConnection.Ds.Tables["enseignant"].Rows[i].Delete();
                        MessageBox.Show("enseignant supprimer déja");
                        dataGridView1.DataSource = singlotonConnection.Ds.Tables["enseignant"];
                        break;
                    }
                }
                }
                if (tr == false)
                {
                    MessageBox.Show("enseignant n'existe pas");
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
                            for (int i = 0; i < singlotonConnection.Ds.Tables["enseignant"].Rows.Count; i++)
            {
                if (id.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i]["id_enseignant"].ToString() || cin.Text == singlotonConnection.Ds.Tables["enseignant"].Rows[i]["cin"].ToString())
                {
                    tr = true;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["nom"] = nom.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["prenom"] = prenom.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["date_naissance"] = date.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["adresse"] = adresse.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["login"] = login.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["motpasse"] = password.Text;
                    singlotonConnection.Ds.Tables["enseignant"].Rows[i]["telephone"] = telephone.Text;
                    if (femme.Checked)
                    {
                        singlotonConnection.Ds.Tables["enseignant"].Rows[i]["sexe"] = "femme";

                    }
                    else
                    {
                        singlotonConnection.Ds.Tables["enseignant"].Rows[i]["sexe"] ="homme";

                    }

                    MessageBox.Show("enseignant modifier déja");
                    dataGridView1.DataSource = singlotonConnection.Ds.Tables["enseignant"];
                    

                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("enseignant n'existe pas");
            }
                        }
                        else
                        {
                            MessageBox.Show("cin ou telephone nom valide");
                        }
                    }
                }

        private void RechCin_TextChanged(object sender, EventArgs e)
        {
 singlotonConnection.Lire("select* from enseignant where nom like '%"+Rech.Text+"%'","enseignant");
            dataGridView1.DataSource = singlotonConnection.Ds.Tables["enseignant"];

        }
    }
    
}
