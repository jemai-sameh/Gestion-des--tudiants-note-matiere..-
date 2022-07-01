using projet.DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projet.Metier
{
    public class MetierFiliereMetiere
    {

        SinglotonConnection singlotonConnection = new SinglotonConnection();



        internal FiliereMetiere GetFiliereMatiere(string rq)
        {
            singlotonConnection.CONNECTER();
            try
            {

                singlotonConnection.Lire(rq, "filiere_matiere");

                if (singlotonConnection.Ds.Tables["filiere_matiere"].Rows.Count > 0)
                {

                    uint id = uint.Parse(singlotonConnection.Ds.Tables["filiere_matiere"].Rows[0]["id"].ToString());
                    Filiere filiere = new MetierFiliere().GetFiliere("select * from filiere where id_filiere=" + int.Parse(singlotonConnection.Ds.Tables["filiere_matiere"].Rows[0]["id_filiere"].ToString()));
                    Matiere matiere = new MetierMatiere().getMatiere("select * from matiere where id_matiere=" + int.Parse(singlotonConnection.Ds.Tables["filiere_matiere"].Rows[0]["id_matiere"].ToString()));

                    return new FiliereMetiere(id, filiere, matiere);

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
