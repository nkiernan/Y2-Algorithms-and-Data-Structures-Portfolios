using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5]; //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");
            books[0].Author.Age = 72;
            books[1] = new Horror("The Creeping");
            books[1].Author.Age = 69;
            books[2] = new Horror("Dracula");
            books[2].Author = new Person("Bram Stoker");
            books[2].Author.Age = 64;
            books[3] = new Book("The Hobbit");
            books[3].Author = new Person("J. R. R. Tolkien");
            books[3].Author.Age = 81;

            //for (int i = 0; i < books.Length - 1; i++)
            //{
            //    Console.WriteLine("{0}  {1}", books[i].Author.Name, books[i].Title);
            //}

            for (int i = 0; i < books.Length - 1; i++)
            {
                Console.WriteLine(books[i].GetSummary() + "\n");
            }
            Console.ReadKey();
        }
    }
}
