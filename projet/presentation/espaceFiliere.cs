using projet.DAO;
using projet.Metier;
using projet.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.application
{
    public partial class espaceFiliere : Form
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();
        public espaceFiliere()
        {
            InitializeComponent();

        }

        private void espaceFiliere_Load(object sender, EventArgs e)
        {
            
            load();
        }
        public void load()
        {
            singlotonConnection.CONNECTER();
            singlotonConnection.Lire("select * from filiere ", "filiere");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["filiere"];
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try { 
            singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
            singlotonConnection.Da.Update(singlotonConnection.Ds, "filiere");
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
            if (nomFiliere.Text == "" || abriviation.Text == "" || id.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            try
            {
                if (Verifint(id.Text))
                {
                    singlotonConnection.Ligne = singlotonConnection.Ds.Tables["filiere"].NewRow();
                    singlotonConnection.Ligne["id_filiere"] = id.Text;
                    singlotonConnection.Ligne["nom_filiere"] = nomFiliere.Text;
                    singlotonConnection.Ligne["abriviation"] = abriviation.Text;

                    for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
                    {
                        if (id.Text.ToString() == singlotonConnection.Ds.Tables["filiere"].Rows[i]["id_filiere"].ToString())
                        {
                            MessageBox.Show("filiere existe déja");
                            return;
                        }
                    }

                    singlotonConnection.Ds.Tables["filiere"].Rows.Add(singlotonConnection.Ligne);
                    MessageBox.Show("enseignant ajouter avec succes");
                    dataGridView.DataSource = singlotonConnection.Ds.Tables["filiere"];
                    return;
                }
            
            }
            catch (SqlException e1)
            {
                MessageBox.Show("erreur " + e1.ToString());

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



        private void modifier_Click_1(object sender, EventArgs e)
        {
            if (nomFiliere.Text == "" || abriviation.Text == "")
            {

                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool exist = false;

            if (Verifint(id.Text))
            {
                for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
                {
                    if (id.Text == singlotonConnection.Ds.Tables["filiere"].Rows[i]["id_filiere"].ToString())
                    {
                        exist = true;
                        singlotonConnection.Ds.Tables["filiere"].Rows[i]["nom_filiere"] = nomFiliere.Text;
                        singlotonConnection.Ds.Tables["filiere"].Rows[i]["abriviation"] = abriviation.Text;


                        MessageBox.Show("filiere modifier déja");
                        dataGridView.DataSource = singlotonConnection.Ds.Tables["filiere"];


                        break;
                    }
                   
                }
                
            }
            if (!exist)
            {
                MessageBox.Show("filiere n'existe pas");
                return;
            }
        }

        private void supprimer_Click_1(object sender, EventArgs e)
        {

            if (nomFiliere.Text == "" || abriviation.Text == "" || id.Text == "")


            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool tr = false;
            if (Verifint(id.Text))
            {
                for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
                {
                    if (id.Text == singlotonConnection.Ds.Tables["filiere"].Rows[i][0].ToString())
                    {
                        tr = true;
                        singlotonConnection.Ds.Tables["filiere"].Rows[i].Delete();
                        MessageBox.Show("filiere supprimer déja");
                        dataGridView.DataSource = singlotonConnection.Ds.Tables["filiere"];
                        break;
                    }
                }
                if (tr == false)
                {
                    MessageBox.Show("filiere n'existe pas");
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
           if (ligne >= 0)
           {
                DataGridViewRow row = this.dataGridView.Rows[ligne];
                id.Text = row.Cells["id_filiere"].Value.ToString();
                nomFiliere.Text = row.Cells["nom_filiere"].Value.ToString();
                abriviation.Text = row.Cells["abriviation"].Value.ToString();

           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ajoutmatierefiliere().Show();
        }

        private void cin_TextChanged(object sender, EventArgs e)
        {
            singlotonConnection.Lire("select* from filiere where abriviation like '%" + rech.Text + "%'", "filiere");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["filiere"];
        }

       
    }
}

