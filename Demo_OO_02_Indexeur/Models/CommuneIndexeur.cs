using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_02_Indexeur.Models
{
    public class CommuneIndexeur
    {
        public List<Commune> _communes = new List<Commune>();

        public Commune? this[string cp]
        {
            get
            {
                foreach (Commune c in this._communes)
                {
                    if (c.CodePostal == cp)
                    {
                        return c;
                    }
                }
                return null;
                //return _communes.FirstOrDefault(c => c.CodePostal == cp);
            }
        }
        public Commune? this[int pos]
        {
            get
            {
                List<Commune> communes = new List<Commune>();
                communes = [.._communes];
                for(int i = 0; i < communes.Count - 2; i++)
                {
                    for(int j = 0; j < communes.Count - 1 - i; j++)
                    {
                        if (communes[j].NbHabitant < communes[j + 1].NbHabitant)
                        {
                            (communes[j], communes[j + 1]) = (communes[j+1], communes[j]);
                        }
                    }
                }
                return communes[pos < 0 ? 0 : (pos >= communes.Count() ? communes.Count() - 1 : pos)];
            }
        }

        //public Commune Get(string cp)
        //{
        //    foreach ( Commune c in this._communes)
        //    {
        //        if(c.CodePostal == cp)
        //        {
        //            return c; 
        //        }
        //    }
        //    return null;
        //}
    }
}
