using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> root = new Node<string>("A");
            BinTree<string> tree = new BinTree<string>(root);
            root.Left = new Node<string>("B");
            root.Right = new Node<string>("C");
            root.Left.Left = new Node<string>("D");
            root.Left.Right = new Node<string>("E");
            root.Right.Left = new Node<string>("F");
            root.Right.Right = new Node<string>("G");
            root.Left.Right.Right = new Node<string>("H");
            string inOrd = "";
            string preOrd = "";
            string posOrd = "";

            tree.InOrder(ref inOrd);
            Console.WriteLine("InOrder: " + inOrd);

            tree.PreOrder(ref preOrd);
            Console.WriteLine("PreOrder: " + preOrd);

            tree.PostOrder(ref posOrd);
            Console.WriteLine("PostOrder: " + posOrd);

            Node<string> root2 = new Node<string>("Z");
            BinTree<string> tree2 = new BinTree<string>(root2);
            root2.Left = new Node<string>("Y");
            root2.Right = new Node<string>("X");
            root2.Left.Left = new Node<string>("W");
            root2.Left.Right = new Node<string>("V");
            root2.Right.Left = new Node<string>("U");
            root2.Right.Right = new Node<string>("T");
            string tree2inOrd = "";

            tree2.InOrder(ref tree2inOrd);
            Console.WriteLine("\nTree2 InOrder: " + tree2inOrd);

            Console.WriteLine("\nCopying Tree2 to Tree:");
            tree.Copy(tree2);

            string copyTreeInOrd = "";

            tree.InOrder(ref copyTreeInOrd);
            Console.WriteLine("\ncopyTree InOrder: " + copyTreeInOrd);

            Console.WriteLine("\nNumber of items in tree: " + tree.Count(tree));

            Console.ReadKey();
        }
    }
}
