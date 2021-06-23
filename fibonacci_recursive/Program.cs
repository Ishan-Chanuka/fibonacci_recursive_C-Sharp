using System;

namespace fibonacci_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a upper boundary");
            int ulimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Sequence");

            for(int i=0; i<ulimit; i++)
            {
                Console.Write(" "+fibonacci(i)+" ");
            }
        }

        static int fibonacci(int no)
        {
            if (no == 0)
            {
                return 0;
            }
            else if(no == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(no - 1) + fibonacci(no - 2);
            }
        }
    }
}
