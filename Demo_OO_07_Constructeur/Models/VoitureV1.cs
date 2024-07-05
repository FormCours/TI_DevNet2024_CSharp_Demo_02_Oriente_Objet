using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_07_Constructeur.Models
{
    public class VoitureV1 : Vehicule
    {
        public int NbPorte { get; set; }
        public string Couleur { get; set; }
        public bool AttacheRemorque { get { return ChargeRemorque > 0; } }
        public int ChargeRemorque { get; set; }

        // Dans cette implementation
        //  - Définir toutes les valeurs par défaut dans le constructeur avec le moins de parametres
        //  - Chaque constructeurs appel un constructeur avec moins de parametre (si possible)
        //  - En cas d'héritage, le constructeur avec le moins de parametre appel le constructeur parent adapté.
        // Objectif : 
        //  - Centraliser les valeurs par default dans le premier constructeur

        public VoitureV1(string marque, string modele, decimal prix, int kilometrage, string couleur)
            : base(marque, modele, prix, kilometrage)
        {
            Console.WriteLine("Ctor -> VoitureV1(marque, modele, prix, kilometrage, couleur)");
            Couleur = couleur;
            NbPorte = 5;
            ChargeRemorque = 0;
        }

        public VoitureV1(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque)
            : this(marque, modele, prix, kilometrage, couleur)
        {
            Console.WriteLine("Ctor -> VoitureV1(marque, modele, prix, kilometrage, couleur, chargeRemorque)");
            ChargeRemorque = chargeRemorque;
        }

        public VoitureV1(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque, int nbPorte)
           : this(marque, modele, prix, kilometrage, couleur, chargeRemorque)
        {
            Console.WriteLine("Ctor -> VoitureV1(marque, modele, prix, kilometrage, couleur, chargeRemorque, nbPorte)");
            NbPorte = nbPorte;
        }

    }
}
