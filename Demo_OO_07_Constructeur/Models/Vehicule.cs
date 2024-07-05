namespace Demo_OO_07_Constructeur.Models
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public decimal Prix { get; set; }
        public int Kilometrage { get; set; }

        public Vehicule(string marque, string modele, decimal prix, int kilometrage)
        {
            Console.WriteLine("Ctor -> Vehicule(marque, modele, prix, kilometrage)");
            Marque = marque;
            Modele = modele;
            Prix = prix;
            Kilometrage = kilometrage;
        }
    }
}
