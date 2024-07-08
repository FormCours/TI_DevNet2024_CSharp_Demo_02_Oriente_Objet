namespace Demo_OO_10_Event.Models
{
    public delegate void TamagotchiFaimEvent(Tamagotchi tamagotchi, string message);
    public delegate void TamagotchiMortEvent(Tamagotchi tamagotchi);

    public class Tamagotchi
    {
        #region Events
        public event TamagotchiFaimEvent? FaimEvent = null;
        public event TamagotchiMortEvent? MortEvent = null;
        #endregion

        #region Constants
        private const int FAIM_MIN = 0;
        private const int FAIM_WARNING = 20;
        private const int FAIM_MAX = 100;
        #endregion

        #region Fields
        private int _JaugeFaim;
        #endregion

        #region Props
        public string Nom { get; set; }
        public bool EstMouru { get; private set; }
        public int JaugeFaim
        {
            get { return _JaugeFaim; }
            private set
            {
                _JaugeFaim = value;

                if (_JaugeFaim <= FAIM_WARNING)
                {
                    FaimEvent?.Invoke(this, "J'ai faim !");
                }
            }
        }
        #endregion

        #region Ctors
        public Tamagotchi(string nom)
        {
            Nom = nom;
            JaugeFaim = FAIM_MAX;
            EstMouru = false;
        }
        #endregion

        #region Methodes
        public void PasserJournee()
        {
            if (EstMouru) return;

            JaugeFaim -= Random.Shared.Next(5, 15);

            if(JaugeFaim <= FAIM_MIN)
            {
                MortEvent?.Invoke(this);
                EstMouru = true;
            }
        }

        public void Nourrir(string repas)
        {
            if (EstMouru) return;

            FaimEvent?.Invoke(this, $"Mange {repas}");
            JaugeFaim = Math.Min(JaugeFaim + 20, FAIM_MAX);
        }
        #endregion
    }
}
