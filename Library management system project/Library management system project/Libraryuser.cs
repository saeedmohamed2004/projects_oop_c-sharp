using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Libraryuser : User
    {
        public Librarycard Card { get; set; }

        public Libraryuser(string name)
        {
            Name = name;
        }

        public void BorrowBooks(Book book,Library library )

        {
            library.Borrowbook(book);

        }
    }
}
