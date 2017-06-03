using System;

namespace StringReversal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string example = "mom";
            char[] myArray = new char[example.Length];          
            myArray = example.ToCharArray(0, example.Length);
            char[] reverseArray = new char[example.Length];

            myArray.CopyTo(reverseArray, 0);
            Array.Reverse(reverseArray);

            string reverseString = reverseArray.ToString();

            Console.WriteLine(myArray);
			Console.WriteLine(reverseArray);

            if (example == reverseString)
            {
                Console.WriteLine("It's a palindrome!");
            } else 
            {
                Console.WriteLine("Not a palindrome.");
            }
		}
    }
}
