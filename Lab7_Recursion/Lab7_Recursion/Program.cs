using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Recursion
{
    class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            if (start == stop)
            {
                /* stopping condition - what needs to be done? */
                Console.WriteLine(start);
            }
            else if (start <= stop)
            {
                /* recursive call and print start*/
                Console.WriteLine(start);
                range(start + 1, stop);
            }
            else if (start >= stop)
            {
                Console.WriteLine(start);
                range(start - 1, stop);
            }
        }

        static string getNumberString(int n)
        {
            if (n == 0)
            {
                return "";
            }
            else
            {
                return n + " " + getNumberString(dec(n));
            }
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }
            else if (y > 1)
            {
                return x + multiply(x, dec(y));
            }
            return x;
        }

        static int power(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }
            else if (y > 1)
            {
                return x * power(x, dec(y));
            }
            return x;
        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }

        static void isPrime(int n)
        {
            int d = 2; //divisor
            if (n == 1)
            {
                Console.WriteLine(n + " is not a prime nummber");
            }
            else if (n == d)
            {
                Console.WriteLine(n + " is a prime number");
            }
            else if (n % d == 0)
            {
                Console.WriteLine(n + " is not a prime number");
            }
            else if (n % d != 0)
            {
                isprime(n, inc(d));
            }
        }

        static void isprime(int n, int d)
        {
            if (n == d)
            {
                Console.WriteLine(n + " is a prime number");
            }
            else if (n % d == 0)
            {
                Console.WriteLine(n + " is not a prime number");
            }
            else if (n % d != 0)
            {
                isprime(n, inc(d));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers from 5 to 0:");
            printNumbers(5);

            Console.WriteLine("\nPrinting numbers between 10 and 5:");
            range(10, 5);

            Console.WriteLine("\n4 * 10 = " + multiply(4, 10));

            Console.WriteLine("\n2 ^ 5 = " + power(2, 5));

            Console.WriteLine("\nTesting dec() and inc():");
            Console.WriteLine("dec(dec(10)) = " + "{0}", dec(dec(10)));
            Console.WriteLine("inc(inc(inc(inc(2)))) = " + "{0}", inc(inc(inc(inc(2)))));
            Console.WriteLine("inc(dec(inc(inc(2)))) = " + "{0}", inc(dec(inc(inc(2)))));

            Console.WriteLine("\nNumbers from 10 to 0 as a string: " + getNumberString(10));

            Console.WriteLine("\nTesting prime numbers between 1 and 20:");
            for (int i = 1; i <= 20; i++)
            {
                isPrime(i);
            }

            Console.ReadLine();
        }
    }
}

