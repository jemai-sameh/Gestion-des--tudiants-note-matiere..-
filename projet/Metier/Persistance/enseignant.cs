using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Enseignant : Identifiant
    {
        private int num_enseignant;


       
        public Enseignant(int cin, string nom, string prenom, int telephone, string adresse, string date_naissance, string sexe, string login, string password, int num_enseignant) : base(cin, nom, prenom, telephone, adresse, date_naissance, sexe, login, password)
        {
            this.Num_enseignant = num_enseignant;
        }

        public int Num_enseignant { get => num_enseignant; set => num_enseignant = value; }
    }
}
