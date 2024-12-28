using System;

namespace DoWhileAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("The value of i is: {0}", i);
                i++;
            } while (i < 5);
        }
    }
}