using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Prefix
    {
        public string getPrefix(string[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }
            for (int i = 0; i < arr[0].Length; i++)
            {
                char c = arr[0][i];
                for (int j = 1; j < arr.Length; j++)
                {
                    if (i == arr[j].Length || arr[j][i] != c)
                        return arr[0].Substring(0, i);
                }
            }
            return arr[0];
        }
            
    }
}
