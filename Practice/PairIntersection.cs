using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class PairIntersection
    {
        public int[] Pair_Intersection(int[] a, int[] b)
        {
            int temp = 0, i = 0, j = 0;
            List<int> intersectPoint = new List<int>();
            int[] resPair = new int[2];
            while (!a[1].Equals(temp))
            {
                if(a[0] < a[1])
                {
                    temp = a[0] + i;
                }
                else
                {
                    temp = a[0] - i;
                }
                int result = intersect(temp, b);
                if (result != 0)
                {
                    intersectPoint.Add(result);
                    j++;
                }
                i++;
            }
            int len = intersectPoint.Count - 1;
            resPair[0] = intersectPoint[0];
            resPair[1] = intersectPoint[len];
            return resPair;
        }
        public int intersect(int temp, int[] b)
        {
            int bLen = 0, k = 0;
            while (!b[1].Equals(bLen))
            {
                bLen = b[0] + k;
                if (temp == bLen)
                {
                    return bLen;
                }
                k++;
            }
            return 0;
        }
    }
}
