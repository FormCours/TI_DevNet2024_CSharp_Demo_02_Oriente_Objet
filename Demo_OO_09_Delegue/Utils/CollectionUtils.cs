using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_09_Delegue.Utils
{
    public delegate bool TrierDelegate(int nb1, int nb2);
    public static class CollectionUtils
    {
        public static List<int> Trier(List<int> numbers, TrierDelegate compare)
        {
            // - Copie de la liste
            List<int> result = new List<int>(numbers);
            //List<int> result = new(numbers);
            //List<int> result = [..numbers];

            // Algo -> Trie a bulles
            for (int i = 0; i < result.Count; i++)
            {
                for (int k = 0; k < (result.Count -i - 1); k++)
                {
                    if (compare(result[k], result[k + 1]))
                    {
                        int temp = result[k];
                        result[k] = result[k + 1];
                        result[k + 1] = temp;
                    }
                }
            }
            return result;
        }
    }
}
