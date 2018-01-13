using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class LinkList
    {
        private Link list = null; //default value – empty list

        public void AddItem(int item) //add item to front of list
        {
            list = new Link(item, list);
        }

        public string DisplayItems() //write items to string and return
        {
            Link temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() // returns number of items in list
        {
            Link temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }

        public bool IsPresentItem(int item)
        {
            Link temp = list;
            while (temp != null)
            {
                if (temp.Data == item)
                {
                    return true;
                }

                temp = temp.Next;
            }
            return false;
        }

        public void RemoveItem(int item)
        {
            Link temp = list;
            while (temp.Next != null)
            {
                if (temp.Next.Data == item)
                {
                    temp.Next = temp.Next.Next;
                }

                temp = temp.Next;
            }
            if(temp.Data.Equals(item))
            {
                list = temp.Next;
            }
        }

        public void AppendItem(int item)
        {
            Link temp = list;
            if (list == null) //case 1
            {
                list = new Link(item);
            }
            else //case 2
            {
                while (temp.Next != null)
                {
                    temp = temp.Next; //move one link
                }
                //ref last link in the list
                temp.Next = new Link(item);
            }

        }

        public void InsertInOrder(int item) //extension
        {
            Link temp = list;
            LinkList newList = new LinkList();
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
    }
}
