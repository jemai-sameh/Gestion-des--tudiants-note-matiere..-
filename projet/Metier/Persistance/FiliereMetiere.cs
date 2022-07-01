namespace projet.Metier
{
    internal class FiliereMetiere
    {
        private uint id;
        private Filiere filiere;
        private Matiere matiere;

        public FiliereMetiere(uint id ,Filiere filiere, Matiere matiere)
        {
            this.Filiere = filiere;
            this.Matiere = matiere;
            this.Id = id;
        }

        public uint Id { get => id; set => id = value; }
        internal Filiere Filiere { get => filiere; set => filiere = value; }
        internal Matiere Matiere { get => matiere; set => matiere = value; }
    }
}