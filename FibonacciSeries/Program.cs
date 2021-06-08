using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            String Str=Console.ReadLine();
            int n1 = Convert.ToInt32(Str);
            int n2, n3, n4;
            n2 = 0;
            n3 = 1;
            n4 = 0;
        
           
            Console.WriteLine("The Fibonacci value of " + n1 + "th number is: "+ f(n1));
            //Method2 Iteration
            Console.WriteLine("Enter another number");
            Str = Console.ReadLine();
            n1 = Convert.ToInt32(Str);
            if (n1 == 0)
                n4 = 0;
            else if (n1 == 1)
                n4 = 1;
            else
                for (int i = 2; i <= n1; i++)
                {
                    n4 = n2 + n3;
                    n2 = n3;
                    n3 = n4;

                }
            Console.WriteLine("The fibonacci value of " + n1 + "th number is: " + n4);
        }
        static int f(int n1)
        {
         if (n1 == 0) return 0;
            else if (n1 == 1) return 1;
            else return f(n1 - 1) + f(n1 - 2);
        }
    }
}
