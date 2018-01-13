using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> test1 = new LinkListGen<int>();

            Console.WriteLine("Testing AddItem: 1, 2, 3, 4");
            test1.AddItem(1);
            test1.AddItem(2);
            test1.AddItem(3);
            test1.AddItem(4);

            Console.WriteLine("\nTesting DisplayList:");
            test1.DisplayList();

            Console.WriteLine("\nTesting NumberOfItems: " + test1.NumberOfItems());

            Console.WriteLine("\nTesting IsPresentItem:");
            Console.WriteLine("3: " + test1.IsPresentItem(3));
            Console.WriteLine("5: " + test1.IsPresentItem(5));

            Console.WriteLine("\nTesting RemoveItem: 4, 2");
            test1.RemoveItem(4);
            test1.RemoveItem(2);
            test1.DisplayList();

            Console.WriteLine("\nTesting AppendItem: 2");
            test1.AppendItem(2);
            test1.DisplayList();

            Console.WriteLine("\nCreate test2 and AppendItem: 4, 5, 6");
            LinkListGen<int> test2 = new LinkListGen<int>();
            test2.AppendItem(4);
            test2.AppendItem(5);
            test2.AppendItem(6);
            test2.DisplayList();

            Console.WriteLine("\nConcat test1 and test2:");
            test1.Concat(test2);
            test1.DisplayList();

            Console.WriteLine("\nCopy test2 to test1:");
            Console.WriteLine("Current test1:");
            test1.DisplayList();
            Console.WriteLine("Current test2:");
            test2.DisplayList();
            test1.Copy(test2);
            Console.WriteLine("Updated test1:");
            test1.DisplayList();
            Console.WriteLine("test2 should remain unchanged:");
            test2.DisplayList();

            LinkListGen<int> test3 = new LinkListGen<int>();
            test3.AppendItem(1);
            test3.AppendItem(2);
            test3.AppendItem(4);
            test3.AppendItem(5);
            Console.WriteLine("\nNew list to test InsertInOrder:");
            test3.DisplayList();
            Console.WriteLine("InsertInOrder: 3");
            test3.InsertInOrder(3);
            test3.DisplayList();

            LinkListGen<int> test4 = new LinkListGen<int>();
            test4.AppendItem(5);
            test4.AppendItem(7);
            test4.AppendItem(4);
            test4.AppendItem(9);
            test4.AppendItem(2);
            Console.WriteLine("\ntest4 unsorted:");
            test4.DisplayList();
            Console.WriteLine("test4 sorted:");
            test4.Sort();
            test4.DisplayList();

            Console.ReadKey();
        }
    }
}
