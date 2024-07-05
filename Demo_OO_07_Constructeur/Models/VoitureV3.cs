using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_07_Constructeur.Models
{
    public class VoitureV3 : Vehicule
    {
        public int NbPorte { get; set; }
        public string Couleur { get; set; }
        public bool AttacheRemorque { get { return ChargeRemorque > 0; } }
        public int ChargeRemorque { get; set; }

        private void Init(string couleur, int chargeRemorque = 0, int nbPorte = 5)
        {
            NbPorte = nbPorte;
            Couleur = couleur;
            ChargeRemorque = chargeRemorque;
        }

        public VoitureV3(string marque, string modele, decimal prix, int kilometrage, string couleur)
          : base(marque, modele, prix, kilometrage)
        {
            Init(couleur);
        }

        public VoitureV3(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque)
            : base(marque, modele, prix, kilometrage)
        {
            Init(couleur, chargeRemorque);
        }

        public VoitureV3(string marque, string modele, decimal prix, int kilometrage, string couleur, int chargeRemorque, int nbPorte)
           : base(marque, modele, prix, kilometrage)
        {
            Init(couleur, chargeRemorque, nbPorte);
        }

    }
}
