namespace Demo_OO_03_SurchageOperateur.Models
{
    public class GroupePersonne
    {
        private List<Personne> _Personnes = new List<Personne>();

        public IEnumerable<Personne> Personnes
        {
            get { return _Personnes.AsReadOnly(); }
        }

        public void Ajouter(Personne personne)
        {
            _Personnes.Add(personne);
        }
        public void Ajouter(List<Personne> personnes)
        {
            foreach (Personne p in personnes)
            {
                Ajouter(p);
            }
        }

        public static GroupePersonne operator +(GroupePersonne g1, GroupePersonne g2)
        {
            GroupePersonne groupe = new GroupePersonne();

            groupe.Ajouter(g1._Personnes);
            groupe.Ajouter(g2._Personnes);

            return groupe;
        }

        public static GroupePersonne operator +(GroupePersonne g, Personne p)
        {
            g.Ajouter(p);
            return g;
        }

        public static GroupePersonne operator +(Personne p, GroupePersonne g)
        {
            return g + p;
        }
    }
}
