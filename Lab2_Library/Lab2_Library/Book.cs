using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Book : IComparable
    {
        private string title;
        private Person author; 

        //property for title:
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //property for author:
        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        //constructor with title
        public Book(string title)
        {
            this.title = title;
        }

        //constructor with author and title
        public Book(Person author, string title)
        {
            this.author = author;
            this.title = title;
        }

        public int CompareTo(Object obj)
        {
            Book other = (Book)obj;
            return Title.CompareTo(other.Title);
        }

        //GetSummary method:
        public string GetSummary()
        {
            return "Book: " + Title + "\nAuthor: " + Author.Name + ", " + Author.Age;
        }
    }
}
