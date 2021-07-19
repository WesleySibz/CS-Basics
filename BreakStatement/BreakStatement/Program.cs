using System;

namespace BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            While working with loops, 
            it is sometimes desirable to skip some statements inside the loop or terminate the loop immediately without checking the test expression.
            In such cases, break and continue statements are used

            The break statement in C# terminates the loop immediately, 
            and the control of the program moves to the next statement following the loop.
             */
            for (int i = 1; i <= 10; ++i)
            {

                // if the value of i is 5 the loop terminates  
                if (i == 5)
                {
                    break;
                }
                    Console.WriteLine(i);
            }
    }
}

}
