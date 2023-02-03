using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Cipher
    {
        public void encrypt(string str, int n)
        {
            string cipher = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsWhiteSpace(str[i]))
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {
                        char temp = str[i];
                        for (int j = 0; j < n; j++)
                        {
                            if (temp == 'Z')
                            {
                                temp = 'A';
                            }
                            else
                                temp += (char)1;
                        }

                        cipher = cipher + temp;
                    }
                    if (str[i] >= 'a' && str[i] <= 'z')
                    {
                        char temp = str[i];
                        for (int j = 0; j < n; j++)
                        {
                            if (temp == 'z')
                            {
                                temp = 'a';
                            }
                            else
                                temp += (char)1;
                        }
                        cipher = cipher + temp;
                    }
                }
                else
                {
                    cipher = cipher + " ";
                }
            }
            Console.WriteLine(cipher);
        }
    }
}
