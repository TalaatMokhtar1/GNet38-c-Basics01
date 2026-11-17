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



            object obj;

            Book book = new Book() { Title = "Assignment", Pages = 100 };

            obj = book;

            Console.WriteLine(obj);

            #endregion


        }
    }
}
