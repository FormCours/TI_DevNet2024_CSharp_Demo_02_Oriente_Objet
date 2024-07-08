using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_09_Delegue.Utils
{
    public delegate void DisplayDelegate(string message);
    public sealed class DisplayUtils
    {
        public DisplayDelegate? DisplayDelegate { get; set; }
        private List<string> _Messages;

        public DisplayUtils()
        {
            DisplayDelegate = null;
            _Messages = new List<string>();
        }

        public void AjouterMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) { return; }

            _Messages.Add(message.Trim());
        }

        public void LancerAffichage()
        {
            if (DisplayDelegate is null) { return; }

            foreach (string message in _Messages)
            {
                DisplayDelegate(message);
            }
        }
    }
}
