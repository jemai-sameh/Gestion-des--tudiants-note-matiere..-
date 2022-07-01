using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Etudiant :Identifiant
    {
        private uint num_etudiant;
        private String niveau;
        private Filiere filiere;
    

       

        public Etudiant(int cin, string nom, string prenom, int telephone, string adresse, string date_naissance, string sexe, string login, string password,String niveau, Filiere filiere, uint num_etudiant) : base(cin, nom, prenom, telephone, adresse, date_naissance, sexe, login, password)
        {
            this.Niveau = niveau;
            this.Filiere = filiere;
            this.Num_etudiant = num_etudiant;
        }

        public uint Num_etudiant { get => num_etudiant; set => num_etudiant = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        internal Filiere Filiere { get => filiere; set => filiere = value; }
    }
}
