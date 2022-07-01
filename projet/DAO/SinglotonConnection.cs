using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace projet.DAO
{
    class SinglotonConnection
    {
       

        // Declaration des objets sql
        private SqlConnection con =new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private DataRow ligne;
        private SqlCommandBuilder bc ;


        // declaration de la methode connecter
        public void CONNECTER()
        {
            if (Con.State == ConnectionState.Closed || Con.State ==ConnectionState.Broken)
            {
                try
                {
                    con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GestionEtudiant; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                    Con.Open();
                }catch (SqlException e)
                {
                    MessageBox.Show("ERREUR" + e.ToString());
                }
                }
        }
        public SqlConnection Con { get => con; set => con = value; }
        public SqlDataAdapter Da { get => da; set => da = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public DataRow Ligne { get => ligne; set => ligne = value; }
       public SqlCommandBuilder Bc { get => bc; set => bc = value; }

        // declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (Con.State == ConnectionState.Open)
            {
              
                Con.Close();
            }
        }
        public DataSet Lire(String rqCH, String tableName)
        {

            try{

            // Exécuter la requete qui charge la table tableName dans la version locale ds
             Da = new SqlDataAdapter(rqCH,Con);

            //Création d'un dataset pour sauvegarder une copie locale de la table tableName
             Ds = new DataSet();
            Da.Fill(Ds, tableName);

           
            }
            catch (SqlException e)
            {
                MessageBox.Show("ERREUR" + e.ToString());
            }
            return Ds;
        }
   


    }
}
