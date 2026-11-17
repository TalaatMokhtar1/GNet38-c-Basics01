using Assignment01.Seconed;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

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
            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double d = pages;
            //Console.WriteLine(d);

            #endregion

            #region Questions 6
            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;
            //int x = (int)price;
            //Console.WriteLine(x);

            #endregion

            #region Questions 7
            //Q07. Given string pagesText = "464";, convert it into an int using the Convert class.

            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);

            #endregion

            #region Questions 8
            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            //string yearText = "2023";

            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //string badText = "abc";
            //bool result = int.TryParse(badText, out int number);

            //if (result)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Questions 9
            //Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            // to prove it's now a string.


            //#region ToString()

            //int pages = 464;
            //string s = pages.ToString();
            //Console.WriteLine(s);

            //#endregion

            //#region GetType()

            //Console.WriteLine(s.GetType());

            #endregion

            #region Questions 10
            //Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            // variable, and print both.

            //int copies = 100;

            //object obj = copies; 

            //int newCopies = (int)obj;

            //Console.WriteLine(copies);
            //Console.WriteLine(newCopies);

            #endregion

            #region Questions 11
            //Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.

            //int? year = null;
            //Console.WriteLine(year.HasValue);

            //year = 2023;
            //Console.WriteLine(year);
            #endregion

            #region Questions 12
            //Q12. Declare a string? reviewer = null;. Print whether it is null.


            //string? reviewer = null;

            //Console.WriteLine(reviewer == null);

            #endregion

            #region Questions 13
            //Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
            //print the result.


            //Book? book = null;

            //Console.WriteLine(book?.Title);

            #endregion

            #region Questions 14
            //Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to
            // assign title the value "Untitled" only if it's still null.

            //Book? book = null;
            //string? title = book?.Title;

            //Console.WriteLine(title ?? "Untitled");

            //title ??= "Untitled";

            #endregion

            #region Questions 15
            //Q15. Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
            //confirmedName using the ! operator.

            //string? name = "Ahmed";
            //string confirmedName = name!;

            //Console.WriteLine(confirmedName);

            #endregion

        }
    }
}
