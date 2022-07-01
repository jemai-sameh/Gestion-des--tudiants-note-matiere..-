using projet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.Metier
{
    class MetierEtudiant
    {
		SinglotonConnection singlotonConnection = new SinglotonConnection();
        internal Etudiant GetEtudiant(string rq)
        {
			singlotonConnection.CONNECTER();
			try
			{
				singlotonConnection.Lire(rq, "etudiant");

				if (singlotonConnection.Ds.Tables != null)
				{
					uint Num_etudiant = uint.Parse(singlotonConnection.Ds.Tables["etudiant"].Rows[0]["id_etudiant"].ToString());
					int Cin = int.Parse(singlotonConnection.Ds.Tables["etudiant"].Rows[0]["cin"].ToString());
					String Nom = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["nom"].ToString();
					String Prenom = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["prenom"].ToString();
					int Telephone = int.Parse(singlotonConnection.Ds.Tables["etudiant"].Rows[0]["telephone"].ToString());
					String Adresse = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["adresse"].ToString();
					String Sexe = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["sexe"].ToString();
					String Login = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["login"].ToString();
					String Date = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["date_naissance"].ToString();
					String Password = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["motpasse"].ToString();
					String niveau = singlotonConnection.Ds.Tables["etudiant"].Rows[0]["niveau"].ToString();
					Filiere filiere =new MetierFiliere().GetFiliere("select * from filiere where id_filiere='"+ singlotonConnection.Ds.Tables["etudiant"].Rows[0]["id_filiere"].ToString()+"'");
					Etudiant etudiant = new Etudiant(Cin, Nom, Prenom, Telephone, Adresse, Date, Sexe, Login, Password,niveau,filiere,Num_etudiant);
					return etudiant;

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
