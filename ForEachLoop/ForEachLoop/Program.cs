using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The syntax of the Java for-each loop is:
            for(dataType item : array) {
                    ...
                }
            array - an array or a collection
            item - each item of array/collection is assigned to this variable
            dataType - the data type of the array/collection

             */
            // create an array
            int[] numbers = { 3, 9, 5, -5 };

            // for loop 
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            //the same task can be done using a for each loop
            char[] myArray2 = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray2)
            {
                Console.Write(ch);
                /*
                In the above program, the foreach loop iterates over the array, myArray. On first iteration, 
                the first element i.e. myArray[0] is selected and stored in ch.
                Similarly on the last iteration, the last element i.e. myArray[4] is selected. 
                Inside the body of loop, the value of ch is printed.
                When we look at both programs, the program that uses foreach loop is more readable and easy to understand. 
                This is because of its simple and expressive syntax.
                Hence, foreach loop is preferred over for loop when working with arrays and collections.    
                    */
            }
        }
    }
}
