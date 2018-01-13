using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_AVLTree
{
    class Program
    {
        static void Main(string[] args)
        { 
            AVLTree<int> test = new AVLTree<int>();
            string ord = "";
            test.InsertItem(25);
            test.InsertItem(15);
            test.InsertItem(10);
            test.InsertItem(20);
            test.InsertItem(23);
            test.InsertItem(17);
            test.InOrder(ref ord);
            Console.WriteLine(ord);

            Console.WriteLine("Height is: " + test.Height());
            test.RemoveItem(10);
            Console.WriteLine("Height is: " + test.Height());
            test.RemoveItem(15);
            Console.WriteLine("Height is: " + test.Height());
            test.RemoveItem(17);
            ord = "";
            test.InOrder(ref ord);
            Console.WriteLine(ord);
            Console.WriteLine("Height is: " + test.Height());

            Console.ReadKey();
        }
    }
}
