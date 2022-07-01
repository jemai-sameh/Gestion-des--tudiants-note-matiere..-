using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Note
    {
		private uint id_note;
		private Matiere matiere;
		private Etudiant etudiant;
		private Double note_examen;
		private Double note_tp;
		private Double note_Orale;
		private Double note_Ds1;
		private Double note_Ds2;
		private Boolean ds;

		public Note(Matiere matiere, Etudiant etudiant, double note_examen, double note_tp, double note_Orale)
		{
			this.matiere = matiere;
			this.etudiant = etudiant;
			this.note_examen = note_examen;
			this.note_tp = note_tp;
			this.note_Orale = note_Orale;
		}

		public Note(Matiere matiere, Etudiant etudiant,double note_Orale, double note_Ds1, double note_Ds2, bool ds)
		{
			this.matiere = matiere;
			this.etudiant = etudiant;
			this.note_Orale = note_Orale;
			this.note_Ds1 = note_Ds1;
			this.note_Ds2 = note_Ds2;
			this.ds = ds;
		}

		public uint Id_note { get => id_note; set => id_note = value; }
		public double Note_examen { get => note_examen; set => note_examen = value; }
		public double Note_tp { get => note_tp; set => note_tp = value; }
		public double Note_Orale { get => note_Orale; set => note_Orale = value; }
		public double Note_Ds1 { get => note_Ds1; set => note_Ds1 = value; }
		public double Note_Ds2 { get => note_Ds2; set => note_Ds2 = value; }
		public bool Ds { get => ds; set => ds = value; }
		internal Matiere Matiere { get => matiere; set => matiere = value; }
		internal Etudiant Etudiant { get => etudiant; set => etudiant = value; }
	}
}
