using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class librarian : User
    {
        public int Employeenum { get; set; }

        public librarian(string name) 
        {
            Name = name;
        }

        public void Addbook(Book newbook, Library library)
        {
            library.Add(newbook);

        }

        public void Removebook(Book newbook, Library library)
        {
            library.Remove(newbook);

        }
    }
}
