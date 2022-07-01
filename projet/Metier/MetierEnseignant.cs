using projet.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.Metier
{
    class MetierEnseignant
    {
		SinglotonConnection singlotonConnection = new SinglotonConnection();
		

        internal Enseignant GetEnseignant(string rq)
        {

			singlotonConnection.CONNECTER();
			try
			{
				singlotonConnection.Lire(rq, "enseignant");

				if (singlotonConnection.Ds != null)
				{
			
					int Num_enseignant = int.Parse(singlotonConnection.Ds.Tables["enseignant"].Rows[0]["id_enseignant"].ToString());
					int Cin = int.Parse(singlotonConnection.Ds.Tables["enseignant"].Rows[0]["cin"].ToString());
					String Nom = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["nom"].ToString();
					String Prenom = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["prenom"].ToString();
					int Telephone = int.Parse(singlotonConnection.Ds.Tables["enseignant"].Rows[0]["telephone"].ToString());
					String Adresse = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["adresse"].ToString();
					String Sexe = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["sexe"].ToString();
					String Login = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["login"].ToString();
					String Date = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["date_naissance"].ToString();
					String Password = singlotonConnection.Ds.Tables["enseignant"].Rows[0]["motpasse"].ToString();

					Enseignant enseignant = new Enseignant(Cin, Nom, Prenom, Telephone, Adresse, Date, Sexe, Login, Password, Num_enseignant);
					return enseignant;

				}


			}
			catch (SqlException e)
			{
				MessageBox.Show("ERREUR " + e.ToString());
			}
			return null;

		}
	}
}
