using Demo_OO_11_Generique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_11_Generique.Utils
{
    public delegate bool FirstElementDelegate<TTarget>(TTarget target);

    public static class CollectionUtilsV2
    {
        public static TElement? GetFirstElement<TElement>(List<TElement> elements, FirstElementDelegate<TElement> del)
        {
            TElement? result = default;

            for (int i = 0; result is null && i < elements.Count; i++)
            {
                TElement target = elements[i];

                if(del(target))
                {
                    result = target;
                }
            }

            return result;
        }
    }
}
