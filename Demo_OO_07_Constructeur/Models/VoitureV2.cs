using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_07_Constructeur.Models
{
    public class VoitureV2 : Vehicule
    {
        public int NbPorte { get; set; }
        public string Couleur { get; set; }
        public bool AttacheRemorque { get { return ChargeRemorque > 0; } }
        public int ChargeRemorque { get; set; }

        // Dans cette implementation
        //  - Définir toutes les valeurs par défaut dans le constructeur avec le plus de parametres
        //  - Chaque constructeurs appel un constructeur avec plus de parametre (si possible)
        //  - En cas d'héritage, le constructeur avec le plus de parametre appel le constructeur parent adapté.
        // Objectif : 
        //  - Eviter plusieurs opérations d'affectation sur les propriétés

        public VoitureV2(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque, int nbPorte)
           : base(marque, modele, prix, kilometrage)
        {
            NbPorte = nbPorte;
            Couleur = couleur;
            ChargeRemorque = chargeRemorque;
        }

        public VoitureV2(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque)
            : this(marque, modele, prix, kilometrage, couleur, chargeRemorque, 5)
        { }

        public VoitureV2(string marque, string modele, decimal prix, int kilometrage, string couleur)
           : this(marque, modele, prix, kilometrage, couleur, 0, 5)
        { }
    }
}
