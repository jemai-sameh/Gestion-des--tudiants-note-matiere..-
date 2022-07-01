using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Matiere
    {
		private uint id_matiere;
		private String nom_matiere;
		private Double coefficient;
		private uint credit;
		private Enseignant enseignant;
		private Boolean ds;

        public Matiere()
        {
        }

        public Matiere(string nom_matiere, double coefficient, uint credit, Enseignant enseignant, bool dS)
		{
			this.nom_matiere = nom_matiere;
			this.coefficient = coefficient;
			this.credit = credit;
			this.enseignant = enseignant;
			this.ds = dS;
		}

		public uint Id_matiere { get => id_matiere; set => id_matiere = value; }
		public string Nom_matiere { get => nom_matiere; set => nom_matiere = value; }
		public double Coefficient { get => coefficient; set => coefficient = value; }
		public uint Credit { get => credit; set => credit = value; }
		public bool DS { get => ds; set => ds = value; }
		internal Enseignant Enseignant { get => enseignant; set => enseignant = value; }
	}
}
