using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10_BSTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing portfolio 9:");
            BSTree<int> tree = new BSTree<int>();
            BSTree<int> tree2 = new BSTree<int>(); //empty tree
            tree.InsertItem(21);
            tree.InsertItem(7);
            tree.InsertItem(30);
            tree.InsertItem(3);
            tree.InsertItem(9);
            tree.InsertItem(24);
            tree.InsertItem(39);
            tree.InsertItem(12);
            
            Console.WriteLine("Tree height is: " + tree.Height());
            Console.WriteLine("Tree contains: " + tree.Count() + " items");
            Console.WriteLine("Tree contains 12: " + tree.Contains(12));
            Console.WriteLine("Tree contains 16: " + tree.Contains(16));

            Console.WriteLine("\nEmpty tree height is: " + tree2.Height());
            Console.WriteLine("Empty tree contains: " + tree2.Count() + " items");
            Console.WriteLine("Empty tree contains 12: " + tree2.Contains(12));

            Console.WriteLine("\nTesting portfolio 10:");
            string treeOrd = "";
            tree.InOrder(ref treeOrd);
            Console.WriteLine("Tree: " + treeOrd);
            tree2.RemoveItem(12); //removal from empty tree
            tree.RemoveItem(3); //0 sub trees
            treeOrd = "";
            tree.InOrder(ref treeOrd);
            Console.WriteLine("\nTree removed 3: " + treeOrd);

            tree.RemoveItem(9); //1 subtree
            treeOrd = "";
            tree.InOrder(ref treeOrd);
            Console.WriteLine("Tree removed 9: " + treeOrd);

            tree.RemoveItem(30); //2 subtrees
            treeOrd = "";
            tree.InOrder(ref treeOrd);
            Console.WriteLine("Tree removed 30: " + treeOrd);

            Console.ReadKey();
        }
    }
}
