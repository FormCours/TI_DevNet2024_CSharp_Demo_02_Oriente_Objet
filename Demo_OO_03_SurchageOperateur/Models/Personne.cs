namespace Demo_OO_03_SurchageOperateur.Models
{
    public class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }


        public static bool operator ==(Personne? p1, Personne? p2)
        {
            // Note : Si on utilise l'opérateur « == » pour tester avec la valeur null,
            //        Notre opérateur sera appelé et cela crée donc une boucle infini :o
            //        Il est préférable d'utiliser l'operateur « is ».
            if (p1 is null && (object?)p2 == null)
                return true;

            if(p1 is null || p2 is null)
                return false; 

            return p1.Prenom == p2.Prenom
                && p1.Nom == p2.Nom
                && p1.Age == p2.Age;
        }
        public static bool operator !=(Personne? p1, Personne? p2)
        {
            return !(p1 == p2);
        }


        public static bool operator >(Personne? p1, Personne? p2)
        {
            if(p1 is null  || p2 is null)
                return false;

            return p1.Age > p2.Age;
        }
        public static bool operator <(Personne? p1, Personne? p2)
        { 
            // On appel l'operateur > entre 2 type Personne, précédement codé
            return p2 > p1;
        }


        public static bool operator >=(Personne? p1, Personne? p2)
        {
            if (p1 is null || p2 is null)
                return false;

            return p1.Age >= p2.Age;
        }
        public static bool operator <=(Personne? p1, Personne? p2)
        {
            return p2 >= p1;
        }


        public static GroupePersonne operator +(Personne p1, Personne p2)
        {
            GroupePersonne groupe = new GroupePersonne();

            groupe.Ajouter(p1);
            groupe.Ajouter(p2);

            return groupe;
        }
    }
}
