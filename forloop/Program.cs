using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            Console.WriteLine("Enter number until which you want the numbers to be displayed");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0; i<n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
