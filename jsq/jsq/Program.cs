using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsq
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result=0;
            Console.WriteLine("请输入第一个运算数：");
            string num11 = Console.ReadLine();
            Console.WriteLine("请输入第二个运算数：");
            string num22 = Console.ReadLine();
            num1 = int.Parse(num11);
            num2 = int.Parse(num22);
            Console.WriteLine("请输入运算方式：");
            string cul= Console.ReadLine();
            switch (cul)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/":
                    if (num2 == 0)
                        Console.WriteLine("除数不能为0");
                    else result = num1 / num2; break;
                default:Console.WriteLine("输入运算符不符合要求");break;
            }

            Console.WriteLine(result);
        }
    }
}
