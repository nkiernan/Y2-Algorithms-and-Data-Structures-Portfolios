using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list = null;

        public LinkListGen(){}

        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }

        public string DisplayList()
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems()
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;
            while (temp != null)
            {
                if (item.Equals(temp.Data))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();            
            while(temp != null)
            {
                if(item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);
                }
                temp = temp.Next;
            }
            list = newList.list;               
        }

        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;
            if (list == null) //case 1
            {
                list = new LinkGen<T>(item);
            }
            else //case 2
            {
                while (temp.Next != null)
                {
                    temp = temp.Next; //move one link
                }
                //ref last link in the list
                temp.Next = new LinkGen<T>(item);
            }
        }

        public void Concat(LinkListGen<T> list2)
        {
            LinkGen<T> temp = list;
            LinkGen<T> temp2 = list2.list;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp.Next != null)
            {
                newList.AppendItem(temp.Data);
                temp = temp.Next; //move one link
                if(temp.Next == null)
                {
                    newList.AppendItem(temp.Data);
                }
            }
            while (temp2.Next != null)
            {
                newList.AppendItem(temp2.Data);
                temp2 = temp2.Next; //move one link
                if (temp2.Next == null)
                {
                    newList.AppendItem(temp2.Data);
                }
            }
            list = newList.list;
        }

        public void Copy(LinkListGen<T> list2)
        {
            LinkGen<T> temp2 = list2.list;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp2.Next != null)
            {
                newList.AppendItem(temp2.Data);
                temp2 = temp2.Next; //move one link
                if (temp2.Next == null)
                {
                    newList.AppendItem(temp2.Data);
                }
            }
            list = newList.list;
        }

        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            if(list == null)
            {
                AddItem(item);
            }
            else
            {
                while(temp != null)
                {
                    if(item.CompareTo(temp.Data) == 1)
                    {
                        newList.AppendItem(temp.Data);
                        temp = temp.Next;
                    }
                    if(item.CompareTo(temp.Data) == -1)
                    {
                        newList.AppendItem(item);
                        newList.AppendItem(temp.Data);
                        temp = temp.Next;
                        break;
                    }
                    newList.AppendItem(temp.Data);
                    temp = temp.Next;
                }
                if(temp.Next == null)
                {
                    newList.AppendItem(temp.Data);
                }
            }
            list = newList.list;
        }

        public void Sort()
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            newList.AppendItem(temp.Data);
            LinkGen<T> temp2 = newList.list;
            temp = temp.Next;
            while (temp != null)
            {
                if(temp.Data.CompareTo(temp2.Data) == 1) //if temp > temp2
                {
                    newList.AppendItem(temp.Data);
                    temp2 = newList.list;
                }
                if (temp.Data.CompareTo(temp2.Data) < 1) //if temp <= temp2
                {
                    newList.AddItem(temp.Data);
                    temp2 = newList.list;
                }

                temp = temp.Next;                
            }
            list = newList.list;
        }
    }
}
