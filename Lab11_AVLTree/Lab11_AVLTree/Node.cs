using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_AVLTree
{
    class Node<T> where T : IComparable
    {
        private T data;
        private int balanceFactor = 0; //added for AVLTree
        public Node<T> Left, Right;

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }
    }

}
