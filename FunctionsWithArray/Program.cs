using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string[] morecolors = { "yellow", "pink", "beige", "purple" };
            PickRandomColor(colors);
            PickRandomColor(morecolors);
        }

        private static void PickRandomColor(string[] someArray)
        {
            Random rnd = new Random();
            int randomindex = rnd.Next(0, someArray.Length);

            Console.WriteLine(someArray[randomindex]);
        }
    }
}
