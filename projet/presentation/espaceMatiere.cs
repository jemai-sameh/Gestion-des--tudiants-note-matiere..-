using projet.DAO;
using projet.Metier;
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
    public partial class espaceMatiere : Form
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();
        public espaceMatiere()
        {
            InitializeComponent();
        }

        private void espaceMatiere_Load(object sender, EventArgs e)
        {
            singlotonConnection.CONNECTER();

            singlotonConnection.Lire("select * from enseignant ", "enseignant");
            for (int i = 0; i < singlotonConnection.Ds.Tables["enseignant"].Rows.Count; i++)
            {
                cmbenseignant.Items.Add(singlotonConnection.Ds.Tables["enseignant"].Rows[i]["nom"].ToString());
               
            }
            singlotonConnection.Lire("select * from matiere ", "matiere");
           // singlotonConnection.Lire("select id_matiere,nom_matiere,credit,Coefficient,DS,CONCAT(prenom,'  ',prenom) AS enseignant from matiere,enseignant where enseignant.id_enseignant=matiere.id_enseignant;", "matiere");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["matiere"];
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
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {

                singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
                singlotonConnection.Da.Update(singlotonConnection.Ds, "matiere");
                MessageBox.Show(" enregistrer ");

            }
            catch (SqlException e2)
            {
                MessageBox.Show("erreur d'enregistrement");

            }
        }

        private void ajout_Click(object sender, EventArgs e)
        {

            if (id.Text==""||nomMatiere.Text == "" || cmbenseignant.SelectedItem==null|| cmbCredit.SelectedItem==null || cmbCoef.SelectedItem ==null)
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }

           
                try
                {
                if (Verifint(id.Text)){
                    singlotonConnection.Ligne = singlotonConnection.Ds.Tables["matiere"].NewRow();
                    singlotonConnection.Ligne["id_matiere"] = int.Parse(id.Text);
                    singlotonConnection.Ligne["nom_matiere"] = int.Parse(id.Text);
                    singlotonConnection.Ligne["nom_matiere"] = nomMatiere.Text;
                    MessageBox.Show(cmbCredit.SelectedItem.ToString() + "  " + cmbCoef.SelectedItem.ToString());
                    singlotonConnection.Ligne["credit"] = int.Parse(cmbCredit.SelectedItem.ToString());
                    singlotonConnection.Ligne["coefficient"] = int.Parse(cmbCoef.SelectedItem.ToString());
                    if (ds.Checked)
                    {
                        singlotonConnection.Ligne["DS"] = true;
                    }
                    else
                    {
                        singlotonConnection.Ligne["DS"] = false;
                    }

                    singlotonConnection.Ligne["id_enseignant"] = new MetierEnseignant().GetEnseignant("select * from enseignant where nom='" + cmbenseignant.SelectedItem.ToString() + "'").Num_enseignant;


                    for (int i = 0; i < singlotonConnection.Ds.Tables["matiere"].Rows.Count; i++)
                    {
                        if (id.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["id_matiere"].ToString() || nomMatiere.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["nom_matiere"].ToString())
                        {
                            MessageBox.Show("matiere existe déja");
                            return;
                        }
                    }


                    singlotonConnection.Ds.Tables["matiere"].Rows.Add(singlotonConnection.Ligne);
                    MessageBox.Show("matiere ajouter avec succes");
                    dataGridView.DataSource = singlotonConnection.Ds.Tables["matiere"];
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

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            
            if (ligne >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[ligne];
                id.Text = row.Cells["id_matiere"].Value.ToString();
                nomMatiere.Text = row.Cells["nom_matiere"].Value.ToString();
                cmbenseignant.SelectedItem = new MetierEnseignant().GetEnseignant("select * from enseignant where id_enseignant='" + int.Parse(row.Cells["id_enseignant"].Value.ToString()) + "'").Nom;
                cmbCoef.SelectedItem = row.Cells["coefficient"].Value.ToString();
                cmbCredit.SelectedItem = row.Cells["credit"].Value.ToString();

            }
        }
    

    private void modifier_Click(object sender, EventArgs e)
        {

            if (id.Text==""||nomMatiere.Text == "" || cmbenseignant.SelectedItem.ToString() == "" || cmbCredit.SelectedItem.ToString() == "" || cmbCoef.SelectedItem.ToString() == "")
            {

                MessageBox.Show(" Merci de remplir les champs");
            return;
        }
            if (Verifint(id.Text)){
                bool exist = false;
                for (int i = 0; i < singlotonConnection.Ds.Tables["matiere"].Rows.Count; i++)
                {
                    if (id.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["id_matiere"].ToString() || nomMatiere.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["nom_matiere"].ToString())
                    {
                        exist = true;
                        //singlotonConnection.Ds.Tables["matiere"].Rows[i]["id_matiere"] = int.Parse(id.Text);
                        singlotonConnection.Ds.Tables["matiere"].Rows[i]["nom_matiere"] = nomMatiere.Text;
                        singlotonConnection.Ds.Tables["matiere"].Rows[i]["credit"] = int.Parse(cmbCredit.SelectedItem.ToString());
                        singlotonConnection.Ds.Tables["matiere"].Rows[i]["coefficient"] = int.Parse(cmbCoef.SelectedItem.ToString());
                        if (ds.Checked)
                        {
                            singlotonConnection.Ds.Tables["matiere"].Rows[i]["DS"] = true;
                        }
                        else
                        {
                            singlotonConnection.Ds.Tables["matiere"].Rows[i]["DS"] = false;
                        }

                        singlotonConnection.Ds.Tables["matiere"].Rows[i]["id_enseignant"] = new MetierEnseignant().GetEnseignant("select * from enseignant where nom='" + cmbenseignant.SelectedItem.ToString() + "'").Num_enseignant;


                        MessageBox.Show("matiere modifier déja");
                        dataGridView.DataSource = singlotonConnection.Ds.Tables["matiere"];


                        break;
                    }
                    

                }
                if (!exist)
                {
                    MessageBox.Show("matiere n'existe pas");
                    return;
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

        private void supprimer_Click(object sender, EventArgs e)
        {

            if (id.Text==""|| nomMatiere.Text == "" || cmbenseignant.SelectedItem.ToString() == "" || cmbCredit.SelectedItem.ToString() == "" || cmbCoef.SelectedItem.ToString() == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
            return;
        }
        bool tr = false;
            if (Verifint(id.Text))
            {

                for (int i = 0; i < singlotonConnection.Ds.Tables["matiere"].Rows.Count; i++)
                {
                    if (id.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["id_matiere"].ToString() || nomMatiere.Text == singlotonConnection.Ds.Tables["matiere"].Rows[i]["nom_matiere"].ToString())
                    {
                        tr = true;
                        singlotonConnection.Ds.Tables["matiere"].Rows[i].Delete();
                        MessageBox.Show("matiere supprimer déja");
                        dataGridView.DataSource = singlotonConnection.Ds.Tables["matiere"];
                        break;
                    }
                }
                if (tr == false)
                {
                    MessageBox.Show("matiere n'existe pas");
                }
            }


    }

        private void abr_TextChanged(object sender, EventArgs e)
        {
            singlotonConnection.Lire("select * from matiere where nom_matiere like '%" + rech.Text + "%'", "matiere");
            dataGridView.DataSource = singlotonConnection.Ds.Tables["matiere"];
        }
    }
}
