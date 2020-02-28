using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);
                if (num <= 0)
                {
                    throw new Exception("Input must be positive");
                }
                while (num != 1)
                {
                    int i = 2;
                    if (num % i == 0)
                    {
                        num /= i;
                        Console.Write(i + " ");
                    }
                    else
                    {
                        i++;
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine("出现异常" + e.Message);
            }
        }
    }
}
