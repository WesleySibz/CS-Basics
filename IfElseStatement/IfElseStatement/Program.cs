using System;

namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if (condition)
             {
                 // statements
             }*/
            /*
             * Here, condition is a boolean expression. It returns either true or false.
             * if condition evaluates to true, statements inside the body of if are executed
             * if condition evaluates to false, statements inside the body of if are skipped
            
             */
            int number = 10;

            // checks if number is greater than 0
            if (number > 0)
            {
               Console.WriteLine("The number is positive.");
            }

            Console.WriteLine("Statement outside if block");
            /*
             Here, the condition is checking if number is greater than 0. 
            Since number is greater than 0, the condition evaluates true.
            If we change the variable to a negative integer. Let's say -5.
             */
        }
    }
}
