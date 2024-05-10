using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Class1
    {
        public void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(5);
            list.Append(9);
            list.Append(8);
            list.Append(3);
            list.Append(-4);
            list.Append(2);
            list.Append(7);
            list.AddToStart(155);
            Console.WriteLine("The first: " + list.Unqueue());
            Console.WriteLine("The last: " + list.Pop());
            Console.WriteLine("The last: " + list.IsCircular());
            Console.WriteLine("The first: " + list.GetMaxNode());
            Console.WriteLine("The first: " + list.GetMinNode());

            list.Sort();
            list.printAll();

        }
    }
}
