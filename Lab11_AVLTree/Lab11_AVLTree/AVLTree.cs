using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_AVLTree
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
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

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            else if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        public new void RemoveItem(T item)
        {
            if (root != null && Contains(item))
            {
                removeItem(item, ref root);
            }
            checkBalance(root);
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

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
            {
                rotateRight(ref tree.Right);
            }
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;
        }

        private void checkBalance(Node<T> root)
        {
            if (root.Data != null)
            {
                root.BalanceFactor = height(root.Left) - height(root.Right);
                if (root.BalanceFactor <= -2 || root.BalanceFactor >= 2)
                {
                    reinsertItem(root);
                }
            }
            if (root.Left != null)
            {
                checkBalance(root.Left);
            }
            if (root.Right != null)
            {
                checkBalance(root.Right);
            }
        }

        private void reinsertItem(Node<T> tree)
        {
            Node<T> temp = tree;
            RemoveItem(tree.Data);
            InsertItem(temp.Data);
        }
    }
}