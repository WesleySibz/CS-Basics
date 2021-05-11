using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
	* Operators are symbols that perform operations on variables and values.
	* For example, + is an operator used for addition, while * is also an operator used for multiplication.
	* Operators in Java can be classified into 5 types:
	*/

            //Arithmetic Operators: Arithmetic operators are used to perform arithmetic operations on variables and data.
            int a = 12, b = 5;

            // addition operator
           Console.WriteLine("a + b = " + (a + b));

            // subtraction operator
            Console.WriteLine("a - b = " + (a - b));

            // multiplication operator
            Console.WriteLine("a * b = " + (a * b));

            // division operator
            Console.WriteLine("a / b = " + (a / b));

            // modulo operator
            Console.WriteLine("a % b = " + (a % b));

            //Assignment Operators: Assignment operators are used in Java to assign values to variables.
            int d = 4;
            int var;

            // assign value using =
            var = d;
            Console.WriteLine("var using =: " + var);

            // assign value using =+
            var += d;
            Console.WriteLine("var using +=: " + var);

            // assign value using =*
            var *= d;
            Console.WriteLine("var using *=: " + var);

            //Relational Operators: Relational operators are used to check the relationship between two operands.
            a = 7;
            b = 11;

            // value of a and b
            Console.WriteLine("a is " + a + " and b is " + b);

            // == operator
            Console.WriteLine(a == b);  // false

            // != operator
            Console.WriteLine(a != b);  // true

            // > operator
            Console.WriteLine(a > b);  // false

            // < operator
            Console.WriteLine(a < b);  // true

            // >= operator
            Console.WriteLine(a >= b);  // false

            // <= operator
            Console.WriteLine(a <= b);  // true

            //Logical Operators: Logical operators are used to check whether an expression is true or false. They are used in decision making.
            // && operator
            Console.WriteLine((5 > 3) && (8 > 5));  // true
            Console.WriteLine((5 > 3) && (8 < 5));  // false

            // || operator
            Console.WriteLine((5 < 3) || (8 > 5));  // true
            Console.WriteLine((5 > 3) || (8 < 5));  // true
            Console.WriteLine((5 < 3) || (8 < 5));  // false

            // ! operator
            Console.WriteLine(!(5 == 3));  // true
            Console.WriteLine(!(5 > 3));  // false

            //Unary Operators: Unary operators are used with only one operand. For example, ++ is a unary operator that increases the value of a variable by 1. That is, ++5 will return 6.
            a = 12;
            b = 12;
            int result1, result2;

            // original value
            Console.WriteLine("Value of a: " + a);

            // increment operator
            result1 = ++a;
            Console.WriteLine("After increment: " + result1);

            Console.WriteLine("Value of b: " + b);

            // decrement operator
            result2 = --b;
            Console.WriteLine("After decrement: " + result2);

            //Bitwise Operators: Bitwise operators in Java are used to perform operations on individual bits.
            /*
            * ~	Bitwise Complement
            <<	Left Shift
            >>	Right Shift
            >>>	Unsigned Right Shift
            &	Bitwise AND
            ^	Bitwise exclusive OR
            * */
            double sinc(double x) => x != 0.0 ? Math.Sin(x) / x : 1;

            Console.WriteLine(sinc(0.1));
            Console.WriteLine(sinc(0.0));
            // Output:
            // 0.998334166468282
            // 1
        }
    }
}
