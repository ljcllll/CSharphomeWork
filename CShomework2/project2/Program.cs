using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a= new int[] { 1, 2, 4, 3, 0, -1, 34, 545, 2, 34 };
                Console.WriteLine("Min:{0}", a.Min());
                Console.WriteLine("Max:{0}", a.Max());
                Console.WriteLine("Average:{0}", a.Average());
                int sum = 0;
                for(int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                Console.WriteLine(sum);
            }
            catch(Exception e)
            {
                Console.WriteLine("出现异常" + e.Message);
            }
        }
    }
}
