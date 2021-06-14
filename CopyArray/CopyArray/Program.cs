using System;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] positiveNumbers = numbers;    // copying arrays

            foreach (int number in positiveNumbers)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine("");
            /*
             In the above example, we have used the assignment operator (=) 
            to copy an array named numbers to another array named positiveNumbers.
            his technique is the easiest one and it works as well. However, there is a problem with this technique. 
            If we change elements of one array, corresponding elements of the other arrays also change.
             */
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            int[] positiveNumbers1 = numbers1;    // copying arrays

            // change value of first array
            numbers1[0] = -1;

            // printing the second array
            foreach (int number1 in positiveNumbers1)
            {
                Console.Write(number1 + ", ");
            }

            int[] source = { 1, 2, 3, 4, 5, 6 };
            int[] destination = new int[6];

            destination = source;
            // iterate and copy elements from source to destination
            foreach (var item in destination)
            {
                Console.WriteLine(item);
            }
        }
    }
}
