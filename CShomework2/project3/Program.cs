using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] a = new bool[101];
            for(int i = 2; i <= 100; ++i)
            {
                a[i] = true;
            }
            for(int i = 2; i < 100; ++i)
            {
                if (a[i])
                {
                    for(int j = i * 2; j <= 100; j++)
                    {
                        a[j] = false;
                    }
                }
            }
            for(int i = 2; i <= 100; ++i)
            {
                if (a[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
