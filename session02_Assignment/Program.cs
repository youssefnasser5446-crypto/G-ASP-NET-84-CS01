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

            #region Question04
            /*
             Write code that divides 10 by 0 inside a try block,
            catches the exception, prints "Cannot divide by zero",
            and then prints "Done" in a finally block.
             */
            //int x = 10, y = 0;
            //try
            //{
            //    int ans = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"cannot divide by zero {ex.Message}");
            //}
            //finally //Main => use in close file and access DB 
            //{
            //    Console.WriteLine("Don!");
            //}
            #endregion

            #region Question05
            /*
             * Declare an int pages = 300; 
             * then store it in a double variable without using a cast.
             */
            //int Pages = 300;
            //double D_Pages = Pages; // implicity casting
            #endregion

            #region Question06
            /*
             * Declare a double price = 49.99;
             * then convert it into an int using a cast.
             */
            //double price = 49.99;
            //int I_Price = (int)price; // convert To Int

            #endregion

            

        }
    }
}
