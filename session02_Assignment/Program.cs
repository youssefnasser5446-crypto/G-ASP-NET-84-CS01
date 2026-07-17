namespace session02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*
             Create a Book class with a Title (string) and Pages (int).
            Create a Book object and store it in a variable of type object.
            Print it. 
             */

            //object Bk = new Book() { title = "C# Basecs", pages = 32 };
            //Console.WriteLine($"The obj is {Bk}");
            #endregion

            #region Question02
            /*
             Using the Book class above, 
            print the result of calling ToString()
            , Equals() (compare book with itself),
            GetHashCode(), and GetType() on book.
             */

            //Console.WriteLine($"The  Book in {Bk.ToString()}");

            //Console.WriteLine($"Are Equals ?: {Bk.Equals(Bk)}");

            //Console.WriteLine($"The HashCode is {Bk.GetHashCode()}");

            //Console.WriteLine($"The Type is {Bk.GetType()}");

            #endregion

            #region Question03
            /*
             Look at the line below. Is it a compile-time error,
            a runtime error, or a logical error? Fix it.
             int pages = "464";
             */
            // int pages = "464";//  answer compiler error

            // int pages = Convert.ToInt32("464"); // sol

            #endregion

            

        }
    }
}
