namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"prices[1] : {prices[1]}");


            #endregion
            #region question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies =
            // {
            //    {3,5},
            //    {1,4}
            // };
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion
            #region question 3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion
            #region question 4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".
            //String title = "Clean Code";

            //PrintBookTitle(title);

            #endregion
            #region question 5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            /*the expected input is still 400 becuase 
            because I called the function with value type 
            so we sent a saperated version not ther referance
            */
            #endregion
            #region question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            //double[] prices= { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"prices[i] : {prices[0]}");
            /*the expected output is 20.5 because I sent the referance 
             * so any changes any variable who has the referance can see it */
            #endregion
            #region question 7 
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            int pages = 400;
            AddBonusPages(ref pages);
            Console.WriteLine($"the pages are {pages}");
            /*the expected output is 450 because I sent the referance */

            #endregion


        }
        #region related to question 3
        static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
        #endregion
        #region related to question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }
        #endregion
        #region related to question 5
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion
        #region related to question 6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion
        #region related to question 7
            //function overloading
            static void AddBonusPages(ref int pages)
            {
                pages += 50;
            }
        #endregion 

    }
}
