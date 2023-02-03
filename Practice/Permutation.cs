using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Permutation
    {
        public void getPossible(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str+",");
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    getPossible(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public string swap(string arr, int i, int j)
        {
            char temp;
            char[] charArray = arr.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
