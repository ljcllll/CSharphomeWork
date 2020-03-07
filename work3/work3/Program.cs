using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{   
    public abstract class shape
    {
        public abstract double getLength();
        public abstract double getArea();
        public abstract void judge();
        public abstract Boolean isOrNot
        {
            set; get;
        }
    }


    public enum ShapeType
    {
        Rectangle,
        Square,
        Triangle,
    }

    public class rectangle : shape
    {
        public double x
        {
            set;get;
        }
        public double y
        {
            set; get;
        }
        public override double getLength()
        {
            double length = 2 * (x + y);
            return length;
        }
        public override double getArea()
        {
            double area = x * y;
            return area;
        }

        public override Boolean isOrNot
        {
            set; get;
        }
        public override void judge()
        {
            if(x>0 && y > 0)
            {
                Console.WriteLine("这是一个长方形");
                isOrNot = true;
            }
            else
            {
                Console.WriteLine("这不是一个长方形");
                isOrNot = false;
            }
            
        }
    }

    public class square : shape
    {
        public double a
        {
            set;get;
        }
        public override Boolean isOrNot
        {
            set; get;
        }
        public override void judge()
        {
            if (a>0)
            {
                Console.WriteLine("这是一个正方形");
                isOrNot = true;
            }
            else
            {
                Console.WriteLine("这不是一个正方形");
                isOrNot = false;
            }
        }
        public override double getLength()
        {
            return a * 4;
        }
        public override double getArea()
        {
            return a * a;
        }

    }

    public class triangle : shape
    {
        public double a
        {
            set;
            get;
        }
        public double b
        {
            set;
            get;
        }
        public double c
        {
            set;
            get;
        }
        public override Boolean isOrNot
        {
            set; get;
        }

        public override void judge()
        {
            if((a+b)<=c | (a+c)<=b | (b+c)<=a | a<=0 | b<=0 | c<=0)
            {
                Console.WriteLine("这不是一个三角形");
                isOrNot = false;
            }
            else
            {
                Console.WriteLine("这是一个三角形");
                isOrNot = true;
            }
        }

        public override double getLength()
        {
            return a + b + c;
        }
        public override double getArea()
        {
            double p = getLength() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
        
    public class ShapeFactory
    {
        public static shape getShape(ShapeType shapetype)
        {
            if(shapetype == ShapeType.Rectangle)
            {
                return new rectangle();
            }
            else if(shapetype == ShapeType.Square)
            {
                return new square();
            }
            else /*if(shapetype == ShapeType.triangle)*/
            {
                return new triangle();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle = new rectangle();
            Console.WriteLine("请输入长方形边长");
            string rec_x = Console.ReadLine();
            rectangle.x = int.Parse(rec_x);
            string rec_y = Console.ReadLine();
            rectangle.y = int.Parse(rec_y);
            rectangle.judge();
            if (rectangle.isOrNot == true)
            {
                Console.WriteLine("长方形周长为：" + rectangle.getLength());
                Console.WriteLine("长方形面积为：" + rectangle.getArea());
            }


            square square = new square();
            Console.WriteLine("请输入正方形边长");
            string sq_a = Console.ReadLine();
            square.a = int.Parse(sq_a);
            square.judge();
            if (square.isOrNot == true)
            {
                Console.WriteLine("正方形周长为：" + square.getLength());
                Console.WriteLine("正方形面积为：" + square.getArea());
            }

            triangle triangle = new triangle();
            Console.WriteLine("请输入三角形的三边");
            string tri_a = Console.ReadLine();
            triangle.a = int.Parse(tri_a);
            string tri_b = Console.ReadLine();
            triangle.b = int.Parse(tri_b);
            string tri_c = Console.ReadLine();
            triangle.c = int.Parse(tri_c);
            triangle.judge();
            if (triangle.isOrNot == true)
            {
                Console.WriteLine("三角形周长为" + triangle.getLength());
                Console.WriteLine("三角形面积为" + triangle.getArea());
            }

            Random random = new Random();
            //int rd = random.Next(1, 4);
            //Console.WriteLine(rd);
            shape[] shapes = new shape[10];
            double areaSum=0;
            for(int i = 0; i < 10; i++)
            {
                int rd = random.Next(1, 4);
                if (rd == 1)
                {
                    shapes[i] = ShapeFactory.getShape(ShapeType.Rectangle);
                    int x = random.Next(1, 10);
                    int y = random.Next(1, 10);
                    //这里我并不知道怎么将x，y赋予rectangle对象shape里面去
                    //导致我getArea函数算不出面积
                    areaSum += shapes[i].getArea();
                }
                else if (rd == 2)
                {
                    shapes[i] = ShapeFactory.getShape(ShapeType.Square);
                    int a = random.Next(1, 10);
                    areaSum += shapes[i].getArea();
                }
                else
                {
                    shapes[i] = ShapeFactory.getShape(ShapeType.Triangle);
                    int a = random.Next(1, 10);
                    int b = random.Next(1, 10);
                    int c = random.Next(1, 10);
                    shapes[i].judge();
                    if (shapes[i].isOrNot == true)
                    {
                        areaSum += shapes[i].getArea();
                    }
                }
            }


            Console.WriteLine(areaSum);

        }
    }
}
