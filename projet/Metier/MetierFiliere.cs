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
    class MetierFiliere
    {
        SinglotonConnection singlotonConnection = new SinglotonConnection();
        
        internal Filiere GetFiliere(string rq)
        {
            singlotonConnection.CONNECTER();
            try
            {
                singlotonConnection.Lire(rq, "filiere");

                if (singlotonConnection.Ds.Tables != null)
                {

                    uint id_filiere = uint.Parse(singlotonConnection.Ds.Tables["filiere"].Rows[0]["id_filiere"].ToString());
                    String nom_filiere = singlotonConnection.Ds.Tables["filiere"].Rows[0]["nom_filiere"].ToString();
                    String abriviation= singlotonConnection.Ds.Tables["filiere"].Rows[0]["abriviation"].ToString();

                    Filiere filiere = new Filiere(id_filiere,abriviation,nom_filiere);
                    return filiere;

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
