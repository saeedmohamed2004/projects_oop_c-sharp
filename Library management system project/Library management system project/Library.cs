using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Library
    {
      private  Book[] books = new Book[100];//max
        
      private int currentbookcount = 0;

      private Book[] boorrowedbooks = new Book[50];

      private int borrowedbookcount = 0;



        public void Display()
        {
            for (int i = 0; i < currentbookcount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }

        public void Add(Book book)
        {
            if (currentbookcount < books.Length)
            {
                books[currentbookcount] = book;
                currentbookcount++;
                Console.WriteLine("Book added Successfully");

            }
            else 
            {
                Console.WriteLine("Library is full , cant add new books");
            }

         }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currentbookcount--;
            Console.WriteLine("Book Removed Successfully");


        }

        public void Borrowbook(Book book) 
        {
            if (borrowedbookcount < boorrowedbooks.Length)
            {
                boorrowedbooks[borrowedbookcount] = book;
                currentbookcount++;
                Console.WriteLine("Book Borrowed Successfully");

            }
            else
            {
                Console.WriteLine("Sorry cant borrow more books");
            }
        }
     
            
        
        
     


    }
}
