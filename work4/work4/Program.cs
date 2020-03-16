using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    public class Node<T>
    {
        public Node<T> Next { set; get; }
        public T Data { set; get; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> x = head; x != null; x = x.Next)
            {
                action(x.Data);
            }
        }
    }







    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            for(Node<int> node = intlist.Head; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
            intlist.ForEach(x => Console.WriteLine(x));
            int sum = 0, max = 0, min = 0;
            intlist.ForEach(x => sum += x);
            intlist.ForEach(x => { if (max < x) max = x; });
            intlist.ForEach(x => { if (min > x) min = x; });
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
