namespace Library_management_system_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library system");

            Library library = new Library();

            Console.WriteLine("Are you Librarian or Regular User ?(L/R)");
            
            var usertype = Console.ReadLine().ToUpper()[0];


            if (usertype == 'L')
            {
                Console.WriteLine("Welcome Librarian, Enter your name ");

                string Librarianname = Console.ReadLine();

                librarian l1 = new librarian(Librarianname);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {

                    Console.WriteLine("Please Choose to Add Book (A) / Remove book (R) / Display book (D)");

                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book Details");
                            string bookname = Console.ReadLine();
                            string Authorname = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book() //object initilaizer
                            {
                                Title = bookname,
                                Author = Authorname,
                                Year = bookYear

                            };
                            l1.Addbook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter book Details to remove");
                            bookname = Console.ReadLine();
                            Authorname = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());

                            book = new Book() //object initilaizer
                            {
                                Title = bookname,
                                Author = Authorname,
                                Year = bookYear

                            };
                            l1.Removebook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("The book list :");
                            l1.DisplayBooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            else if (usertype == 'R')
            {
                Console.WriteLine("Welcome user, Enter your name ");

                string name = Console.ReadLine();

                Libraryuser u1 = new Libraryuser(name);
                Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {

                    Console.WriteLine("Please Choose to  Display book (D) / Borrow book (B)");

                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {

                        case 'D':
                            Console.WriteLine("The book list :");
                            u1.DisplayBooks(library);
                            break;
                        case 'B':
                            Console.WriteLine("Enter book Details to borrow");
                            string bookname = Console.ReadLine();
                            string Authorname = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book() //object initilaizer
                            {
                                Title = bookname,
                                Author = Authorname,
                                Year = bookYear

                            };
                            u1.BorrowBooks(book, library);
                            break;
                        
                        default:
                            Environment.Exit(0);
                            break;
                    }

                }

            }
            else
            {
                Console.WriteLine("PLease Enter Correct Value (L or R)");
            }

            











        }
    }
}
