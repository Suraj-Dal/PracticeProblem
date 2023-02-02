using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class VendingMachine
    {
        public void getChange(double price_of_item, int totalMoney)
        {
            int[] coins = new int[] { 100, 50, 25, 10, 5, 1 };
            int[] outputArr = new int[6];
            int amt = Convert.ToInt32((totalMoney - price_of_item) * 100);
            int i = 0;
            int total = 0;
            Console.WriteLine("coins given in change are:");
            while (amt != 0)
            {
                int change = amt / coins[i];
                int rem = amt % coins[i];
                amt = rem;
                total += change;
                outputArr[i] = change;
                if (change != 0)
                    Console.WriteLine(change + " coins of " + coins[i]);
                i++;
            }
            Console.WriteLine("Total no. of coins needed." + total);
            for (i = 0; i < outputArr.Length; i++)
            {
                Console.Write(outputArr[i] + ",");
            }
        }
    }
}
