using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Filiere
    {
        private uint id_filiere;
        private String abriviation;
        private String nom_filiere;

        public Filiere(uint id_filiere,string abriviation, string nom_filiere)
        {
            this.abriviation = abriviation;
            this.nom_filiere = nom_filiere;
            this.id_filiere = id_filiere;
           
        }

        public uint Id_filiere { get => id_filiere; set => id_filiere = value; }
        public string Abriviation { get => abriviation; set => abriviation = value; }
        public string Nom_filiere { get => nom_filiere; set => nom_filiere = value; }
       
    }
}
