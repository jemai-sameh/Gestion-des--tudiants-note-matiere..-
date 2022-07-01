using projet.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace projet.Metier
{
    class MetierMatiere
    {
		SinglotonConnection singlotonConnection = new SinglotonConnection();
		

		internal Matiere getMatiere(string rq)
		{
			singlotonConnection.CONNECTER();
			
			try
			{
				singlotonConnection.Lire(rq, "matiere");
				if (singlotonConnection.Ds.Tables["matiere"].Rows.Count>0)
				{	Matiere matiere = new Matiere();

						matiere.Id_matiere = uint.Parse(singlotonConnection.Ds.Tables["matiere"].Rows[0]["id_matiere"].ToString());
						matiere.Nom_matiere = singlotonConnection.Ds.Tables["matiere"].Rows[0]["nom_matiere"].ToString();
						matiere.Credit = uint.Parse(singlotonConnection.Ds.Tables["matiere"].Rows[0]["credit"].ToString());
						matiere.Coefficient = uint.Parse(singlotonConnection.Ds.Tables["matiere"].Rows[0]["Coefficient"].ToString());
						matiere.Enseignant = new MetierEnseignant().GetEnseignant("select * from enseignant where id_enseignant='" + int.Parse(singlotonConnection.Ds.Tables["matiere"].Rows[0]["id_enseignant"].ToString())+"'");
					if (singlotonConnection.Ds.Tables["matiere"].Rows[0]["Ds"].ToString().Equals("0"))
					{
						matiere.DS = false;
					}
					else
					{
						matiere.DS = true;
					}
					return matiere;


					


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
