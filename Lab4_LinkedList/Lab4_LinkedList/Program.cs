using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();

            testList.AddItem(6);
            testList.AddItem(5);
            testList.AddItem(4);
            testList.AddItem(3);
            testList.AddItem(2);
            testList.AddItem(1);
            testList.DisplayItems();

            Console.WriteLine("\nNumber of items: {0}", testList.NumberOfItems());

            Console.WriteLine("28 present: {0}", testList.IsPresentItem(28));
            Console.WriteLine("2  present: {0}", testList.IsPresentItem(2) + "\n");

            Console.WriteLine("\nRemove 4:");
            testList.RemoveItem(4);
            testList.DisplayItems();

            Console.WriteLine("\nInsert 4 in order:");
            testList.InsertInOrder(4);
            testList.DisplayItems();

            Console.ReadKey();

        }
    }
}
