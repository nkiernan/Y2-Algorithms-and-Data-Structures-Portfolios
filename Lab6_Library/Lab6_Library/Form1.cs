using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Library
{
    public partial class Form1 : Form
    {
        Dictionary<string, Book> library = new Dictionary<string, Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            string newIsbn = isbnTextBox.Text;
            string newTitle = titleTextBox.Text;
            Book book = new Book(newIsbn, newTitle);

            if (!library.ContainsKey(newIsbn))
            {
                library.Add(book.ISBN, book);
                bookDetailsLabel.Text = "Book Details: Book Added";
                displayIsbn.Text = "ISBN: " + book.ISBN;
                displayTitle.Text = "Title: " + book.Title;
                loanLabel.Text = "On Loan: " + book.Onloan;
            }

            else if (library.ContainsKey(newIsbn))
            {
                bookDetailsLabel.Text = "Book Details: Book Already Exists";
                displayIsbn.Text = "ISBN: ";
                displayTitle.Text = "Title: ";
                loanLabel.Text = "On Loan: ";                 
            }                      
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            string removeIsbn = isbnTextBox.Text;

            if (library.ContainsKey(removeIsbn))
            {
                library.Remove(removeIsbn);
                bookDetailsLabel.Text = "Book Details: Book Removed";
                displayIsbn.Text = "ISBN: ";
                displayTitle.Text = "Title: ";
                loanLabel.Text = "On Loan: ";
            }

            else if (!library.ContainsKey(removeIsbn))
            {
                bookDetailsLabel.Text = "Book Details: No such ISBN";
                displayIsbn.Text = "ISBN: ";
                displayTitle.Text = "Title: ";
                loanLabel.Text = "On Loan: ";
            }
        }

        private void searchIsbnButton_Click(object sender, EventArgs e)
        {
            string searchIsbn = isbnTextBox.Text;

            foreach (KeyValuePair<string, Book> b in library)
            {
                if (library.ContainsKey(searchIsbn))
                {
                    bookDetailsLabel.Text = "Book Details: Found ISBN";
                    displayIsbn.Text = "ISBN: " + b.Value.ISBN;
                    displayTitle.Text = "Title: " + b.Value.Title;
                    loanLabel.Text = "On Loan: " + b.Value.Onloan;
                }

                else if (!library.ContainsKey(searchIsbn))
                {
                    bookDetailsLabel.Text = "Book Details: No such ISBN";
                    displayIsbn.Text = "ISBN: ";
                    displayTitle.Text = "Title: ";
                    loanLabel.Text = "On Loan: ";
                }
            }
        }

        private void searchTitleButton_Click(object sender, EventArgs e)
        {
            string searchTitle = titleTextBox.Text;

            foreach (KeyValuePair<string, Book> b in library)
            {
                if (b.Value.Title.Contains(searchTitle))
                {
                    bookDetailsLabel.Text = "Book Details: Found in Title";
                    displayIsbn.Text = "ISBN: " + b.Value.ISBN;
                    displayTitle.Text = "Title: " + b.Value.Title;
                    loanLabel.Text = "On Loan: " + b.Value.Onloan;
                }

                else if (!b.Value.Title.Contains(searchTitle))
                {
                    bookDetailsLabel.Text = "Book Details: No such Title";
                    displayIsbn.Text = "ISBN: ";
                    displayTitle.Text = "Title: ";
                    loanLabel.Text = "On Loan: ";
                }
            }
        }

        private void changeLoanButton_Click(object sender, EventArgs e)
        {
            string changeLoanIsbn = isbnTextBox.Text;

            foreach (KeyValuePair<string, Book> b in library)
            {
                if (library.ContainsKey(changeLoanIsbn) && b.Value.Onloan.Equals(true))
                {
                    b.Value.Onloan = false;
                    bookDetailsLabel.Text = "Book Details: Loan Changed";
                    displayIsbn.Text = "ISBN: " + b.Value.ISBN;
                    displayTitle.Text = "Title: " + b.Value.Title;
                    loanLabel.Text = "On Loan: " + b.Value.Onloan;
                }

                else if (library.ContainsKey(changeLoanIsbn) && b.Value.Onloan.Equals(false))
                {
                    b.Value.Onloan = true;
                    bookDetailsLabel.Text = "Book Details: Loan Changed";
                    displayIsbn.Text = "ISBN: " + b.Value.ISBN;
                    displayTitle.Text = "Title: " + b.Value.Title;
                    loanLabel.Text = "On Loan: " + b.Value.Onloan;
                }

                else if (!library.ContainsKey(changeLoanIsbn))
                {
                    bookDetailsLabel.Text = "Book Details: No such ISBN";
                    displayIsbn.Text = "ISBN: ";
                    displayTitle.Text = "Title: ";
                    loanLabel.Text = "On Loan: ";
                }
            }
        }
    }
}
