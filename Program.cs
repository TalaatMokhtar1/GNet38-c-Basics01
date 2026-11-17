using Assignment01.Seconed;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Questions 1
            //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.



            //object obj;

            //Book book = new Book() { Title = "Assignment", Pages = 100 };

            //obj = book;

            //Console.WriteLine(obj);

            #endregion

            #region Questions 2
            //Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book.

            // Book book = new Book() { Title = "Assignment", Pages = 100 };

            #endregion

            #region ToString()

            // Console.WriteLine(book.ToString());

            #endregion

            #region Equals()

            // Console.WriteLine(book.Equals(book));

            #endregion

            #region GetHashCode()

            //Console.WriteLine(book.GetHashCode());

            #endregion

            #region GetType()

            //Console.WriteLine(book.GetType());

            #endregion

            #region Questions 3
            //-Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";

            // Compile-time error
            // int pages = "464";

            // Fix:
            //  int pages = 464;

            // Console.WriteLine(pages);

            #endregion

            #region Questions 4
            //Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Questions 5

            //int pages = 300;
            //double d = pages;
            //Console.WriteLine(d);

            #endregion

        }
    }
}
