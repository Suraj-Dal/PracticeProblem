using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SquarePicker
    {
        public void getSquare(int[] arr)
        {
            List<int> list = new List<int>();   
            for (int i = 0; i < arr.Length; i++)
            {
               double sqrt = Math.Sqrt(arr[i]);
               if(sqrt % 2 == 0 || sqrt % 1 == 0)
               {
                    list.Add(arr[i]);
               }
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[min])
                        min = j;
                }
                int temp = list[min];
                list[min] = list[i];
                list[i] = temp;
            }
            foreach(int a in list)
            {
                Console.Write(a + ",");
            }
        }
    }
}
