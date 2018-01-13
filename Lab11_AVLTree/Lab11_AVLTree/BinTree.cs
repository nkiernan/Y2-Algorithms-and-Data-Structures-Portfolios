using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_AVLTree
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + " ";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + " ";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + " ";
            }
        }

        public void Copy(BinTree<T> tree2)
        {
            copy(ref root, tree2.root);
        }

        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            root.Data = tree2.Data;
            root.Left = tree2.Left;
            root.Right = tree2.Right;
        }

        public int Count() //Return the number of nodes in the tree
        {
            int counter = 0;
            if (root != null)
            {
                counter = count(root);
            }
            return counter;
        }

        private int count(Node<T> root)
        {
            int counter = 1;
            if (root.Left != null)
            {
                counter += count(root.Left);
            }
            if (root.Right != null)
            {
                counter += count(root.Right);
            }
            return counter;
        }

        public int Height() //Return the max level of the tree
        {
            int h = 0;
            if (root != null)
            {
                h = height(root);
            }
            return h;
        }

        protected int height(Node<T> root)
        {
            int h = 0;
            if (root != null)
            {
                h = 1 + Math.Max(height(root.Left), height(root.Right));
            }
            return h;
        }

        public Boolean Contains(T item)
        //Return true if the item is contained in the BSTree, false otherwise.
        {
            if (root == null)
            {
                return false;
            }
            else return contains(root, item);
        }

        private Boolean contains(Node<T> root, T item)
        {
            if (item.CompareTo(root.Data) == 0 && root.Data != null)
            {
                return true;
            }
            else if (item.CompareTo(root.Data) < 0 && root.Left != null)
            {
                return contains(root.Left, item);
            }
            else if (item.CompareTo(root.Data) > 0 && root.Right != null)
            {
                return contains(root.Right, item);
            }
            return false;
        } 
    }
}