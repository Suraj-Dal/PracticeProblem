using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Pyramid
    {
        public int[] Pyramid_Arrangement(int[] arr, int n)
        {
           
            int[] sortedArr = new int[n];
            int mid = (sortedArr.Length / 2) - 1;
            int tmp, k = mid -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            for (int i = n - 1; i > 0 ; i = i - 2)
            {
                
                if (mid < sortedArr.Length)
                {
                    sortedArr[mid] = arr[i];
                    mid++;
                }

                if (k != -1)
                {
                    sortedArr[k] = arr[i - 1];
                    k--;
                }
                
            }
            return sortedArr;
        }
    }
}
