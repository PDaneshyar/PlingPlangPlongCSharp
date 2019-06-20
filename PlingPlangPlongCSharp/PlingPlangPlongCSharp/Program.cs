using System;

namespace PlingPlangPlongCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlingPlangPlong(3));
            Console.WriteLine(PlingPlangPlong(5));
            Console.WriteLine(PlingPlangPlong(7));
            Console.WriteLine(PlingPlangPlong(105));
        }

        // this is a static method so that there is no need to instantiate the program class
        public static string PlingPlangPlong(int number)
        {
            string response = "";

            // returns the number as a string if no factors of 3,5,7
            if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                response = number.ToString();
            }

            // concatenates the string if it finds a factor of 3,5,7
            if (number % 3 == 0)
            {
                response += "Pling";
            }

            if (number % 5 == 0)
            {
                response += "Plang";
            }

            if (number % 7 == 0)
            {
                response += "Plong";
            }

            return response;
        }
    }
}
