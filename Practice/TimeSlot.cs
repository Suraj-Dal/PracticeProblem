using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TimeSlot
    {
        public void getAppoinment(int[][] arr)
        {
            
            List <int[]> slot = new List<int[]>();
            int start = 0, end = 24;
            for (int i = 0; i < arr.Length; i++)
            {
                int[] temp = new int[2];
                if (start != arr[i][0] && start != end)
                {
                    temp[0] = start;
                    temp[1] = arr[i][0];
                    start = arr[i][1];
                }
                slot.Add(temp);
            }
            if (start != end)
            {
                int[] temp = new int[2];
                temp[0] = start;
                temp[1] = end;
                slot.Add(temp);
            }
            Console.WriteLine("Available slots:");
            foreach (int[] arr2 in slot)
            {
                Console.WriteLine("{"+ arr2[0]+","+ arr2[1]+"}");
            }
        }
    }
}
