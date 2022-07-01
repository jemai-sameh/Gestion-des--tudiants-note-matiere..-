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
	public partial class ajoutmatierefiliere : Form
	{
		SinglotonConnection singlotonConnection = new SinglotonConnection();
		public ajoutmatierefiliere()
		{
			InitializeComponent();

		}

		private void ajoutmatierefiliere_Load(object sender, EventArgs e)
		{
			singlotonConnection.CONNECTER();
			singlotonConnection.Lire("select * from filiere ", "filiere");
			cmbfiliere.Items.Add("choisir filiere");
			cmbfiliere.SelectedIndex = 0;

			for (int i = 0; i < singlotonConnection.Ds.Tables["filiere"].Rows.Count; i++)
			{
				cmbfiliere.Items.Add(singlotonConnection.Ds.Tables["filiere"].Rows[i]["nom_filiere"].ToString());

			}
			singlotonConnection.Lire("select * from matiere ", "matiere");
			cmbmatiere.Items.Add("choisir matiere");
			cmbmatiere.SelectedIndex = 0;
			for (int i = 0; i < singlotonConnection.Ds.Tables["matiere"].Rows.Count; i++)
			{
				cmbmatiere.Items.Add(singlotonConnection.Ds.Tables["matiere"].Rows[i]["nom_matiere"].ToString());

			}

			singlotonConnection.Lire("select * from filiere_matiere ", "filiere_matiere");
			dataGridView1.DataSource = singlotonConnection.Ds.Tables["filiere_matiere"];

		}

		private void Enregistrer_Click(object sender, EventArgs e)
		{
		   
			try
			{
				singlotonConnection.Bc = new SqlCommandBuilder(singlotonConnection.Da);
				singlotonConnection.Da.Update(singlotonConnection.Ds, "filiere_matiere");
				MessageBox.Show(" enregistrer ");

			}
			catch (SqlException e2)
			{
				MessageBox.Show("erreur d'enregistrement");

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
				MessageBoxButtons.YesNo)== DialogResult.Yes)
			{
				VIDER(this);
			}

		}

		private void supprimer_Click(object sender, EventArgs e)
		{

			if (cmbfiliere.SelectedItem.ToString() == "" || cmbfiliere.SelectedIndex == -1 || cmbmatiere.SelectedItem.ToString() == "" || cmbmatiere.SelectedIndex == -1)
			{
				MessageBox.Show(" Merci de remplir les champs");
				return;
			}
			Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbmatiere.SelectedItem.ToString() + "'");
			Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbfiliere.SelectedItem.ToString() + "'");

			bool tr = false;
			FiliereMetiere filiereMetiere = new MetierFiliereMetiere().GetFiliereMatiere("select * from filiere_matiere where id_filiere = " + filiere.Id_filiere + "and id_matiere=" + matiere.Id_matiere);

			for (int i = 0; i < singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Count; i++)
			{
				if (filiereMetiere.Id.ToString() == singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id"].ToString())
				{

					tr = true;
					singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i].Delete();
					MessageBox.Show("supprimer avec succés");
					dataGridView1.DataSource = singlotonConnection.Ds.Tables["filiere_matiere"];

					break;
				}
			}
			if (tr == false)
			{
				MessageBox.Show(" n'existe pas");
			}
		

	}

		private void modifier_Click(object sender, EventArgs e)
		{
			if (cmbfiliere.SelectedItem.ToString() == "" || cmbfiliere.SelectedIndex == -1 || cmbmatiere.SelectedItem.ToString() == "" || cmbmatiere.SelectedIndex == -1)
			{

				MessageBox.Show(" Merci de remplir les champs");
				return;
			}
			Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbmatiere.SelectedItem.ToString() + "'");
			Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbfiliere.SelectedItem.ToString() + "'");
			FiliereMetiere filiereMetiere = new MetierFiliereMetiere().GetFiliereMatiere("select * from filiere_matiere where id_filiere = " + filiere.Id_filiere + "and id_matiere=" + matiere.Id_matiere);

			for (int i = 0; i < singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Count; i++)
			{
				if (filiereMetiere.Id.ToString() == singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id"].ToString()) { 

					singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id_filiere"] = filiere.Id_filiere;
					singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id_matiere"] = matiere.Id_matiere;


					MessageBox.Show("modifier déja");
					dataGridView1.DataSource = singlotonConnection.Ds.Tables["filiere_matiere"];
					break;
				}
				else
				{
					MessageBox.Show("filiere n'existe pas");

				}
			}

		}

		private void ajout_Click(object sender, EventArgs e)
		{
			if ( cmbfiliere.SelectedIndex == -1 || cmbmatiere.SelectedIndex == -1)
			{
				MessageBox.Show(" Merci de remplir les champs");
				return;
			}
			try
			{
				Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where nom_matiere='" + cmbmatiere.SelectedItem.ToString() + "'");
				Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where nom_filiere='" + cmbfiliere.SelectedItem.ToString() + "'");

				singlotonConnection.Ligne = singlotonConnection.Ds.Tables["filiere_matiere"].NewRow();
				singlotonConnection.Ligne["id_filiere"] =filiere.Id_filiere;
				singlotonConnection.Ligne["id_matiere"] = matiere.Id_matiere;
				FiliereMetiere filiereMetiere = new MetierFiliereMetiere().GetFiliereMatiere("select * from filiere_matiere where id_matiere=" + matiere.Id_matiere + " and id_filiere=" + filiere.Id_filiere);

				for (int i = 0; i < singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Count; i++)
				{
				   if (filiereMetiere != null)
					{
						if (filiereMetiere.Id.ToString() == singlotonConnection.Ds.Tables["filiere_matiere"].Rows[i]["id"].ToString())
						{

							MessageBox.Show("filiere existe déja");
							return;
						}
					}
					
				}

				singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Add(singlotonConnection.Ligne);
				MessageBox.Show("ajouter avec succes");
				dataGridView1.DataSource = singlotonConnection.Ds.Tables["filiere_matiere"];

			}
			catch (SqlException e1)
			{
				MessageBox.Show("erreur " + e1.ToString());

			}
		}

	  

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int ligne = e.RowIndex;
			if (ligne >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[ligne];
				cmbfiliere.SelectedItem = new MetierFiliere().GetFiliere("Select *from filiere where id_filiere="+ int.Parse(row.Cells["id_filiere"].Value.ToString())).Nom_filiere;
			   cmbmatiere.SelectedItem= new MetierMatiere().getMatiere("Select *from matiere where id_matiere=" + int.Parse(row.Cells["id_matiere"].Value.ToString()) ).Nom_matiere;

			}
		}
	}
}
