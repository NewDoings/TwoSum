using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSumboody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nume = new int[]{ 3,2,1,3};
            int target = 6;
            int[] sum = TowSum(nume, target);
            Console.WriteLine(sum[0].ToString() + sum[1].ToString());
            Console.ReadKey();
        }
        public static int[] TowSum(int[] nume, int target)
        {
            int[] sum = new int[2];
            for (int i = 0; i < nume.Length; i++)
            {
                for (int j = i + 1; j < nume.Length; j++)
                {
                    if (nume[i] + nume[j] == target)
                    {
                        //sum[0] = Array.IndexOf(nume,nume[i]);
                        //sum[1] = Array.IndexOf(nume, nume[i+1]);
                        sum[0] = i;
                        sum[1] = j;
                        break;
                    }
                }
            }
            return sum;
        }
    }
}
