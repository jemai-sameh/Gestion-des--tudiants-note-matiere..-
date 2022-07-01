using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Metier
{
    class Identifiant
    {
		private int cin;
		private String nom;
		private String prenom;
		private int telephone;
		private String adresse;
		private String date_naissance;
		private String sexe;
		private String login;
		private String Password;
	

		public Identifiant(int cin, string nom, string prenom, int telephone, string adresse, string date_naissance, string sexe, string login, string password)
		{
			this.Cin = cin;
			this.Nom = nom;
			this.Prenom = prenom;
			this.Telephone = telephone;
			this.Adresse = adresse;
			this.Date_naissance = date_naissance;
			this.Sexe = sexe;
			this.Login = login;
			Password1 = password;
		
		}

		public int Cin { get => cin; set => cin = value; }
		public string Nom { get => nom; set => nom = value; }
		public string Prenom { get => prenom; set => prenom = value; }
		public int Telephone { get => telephone; set => telephone = value; }
		public string Adresse { get => adresse; set => adresse = value; }
		public string Date_naissance { get => date_naissance; set => date_naissance = value; }
		public string Sexe { get => sexe; set => sexe = value; }
		public string Login { get => login; set => login = value; }
		public string Password1 { get => Password; set => Password = value; }
	
	}
}
