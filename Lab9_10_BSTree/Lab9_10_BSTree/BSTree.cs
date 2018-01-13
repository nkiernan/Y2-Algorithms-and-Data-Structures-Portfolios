using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10_BSTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {   //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            if (!Contains(item))
            {
                insertItem(item, ref root);
            }
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }  
        
        public void RemoveItem(T item) 
        {
            if (root != null && Contains(item))
            {
                removeItem(item, ref root);
            }
        }
        
        private void removeItem(T item, ref Node<T> tree)
        {
            if (item.CompareTo(tree.Data) < 0 && tree.Left != null)
            { 
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0 && tree.Right != null)
            {
                removeItem(item, ref tree.Right);
            }
            //found item:
            else if (tree.Left == null)
            {
                tree = tree.Right;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
            }
            else
            {
                T newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
            }      
        }
        
        private T leastItem(Node<T> tree) //helper method for removeItem
        {
            if (tree.Left == null) //stopping condition
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }
    }
}
