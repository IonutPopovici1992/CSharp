using System;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int a, b, x, y;

            // Assignment operator
            a = 0;
            b = 1;
            x = 2;
            y = 3;

            // There are many mathematical operators ...

            // Addition operator
            x = 3 + 4;

            // Substraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // There are many operators used to evaluate values ...

            // Equality operator
            if (x == y)
            {
            }

            // Greater than operator
            if (x > y)
            {
            }

            // Less than operator
            if (x < y)
            {
            }

            // Greater than or equal to operator
            if (x >= y)
            {
            }

            // Less than or equal to operator
            if (x <= y)
            {
            }


            // There are two "conditional" operators as well
            // that can be used to expand / enhance an evaluation ...
            // ... and they can be combined togheter multiple times.

            // Conditional AND operator ...
            if ((a > b) && (x > y))
            {
            }

            // Conditional OR operator
            if ((a > b) || (x > y))
            {
            }

            // Also, here's the in-line conditional operator
            // we learned about in the previous lesson ...
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            Console.WriteLine("Hi!!!");
            Console.ReadLine();
        }
    }
}
