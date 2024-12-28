using System;

namespace DoWhileAssignment

{
    class Program
    {
        static void Main(string[] args)
        {

            // Do-While Part
            int counter = 0;
            int user_limit;
            Console.WriteLine("Lütfen bir limit giriniz: ");
            user_limit = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter++;
            } while (counter <= user_limit);


            // While Part

            counter = 0;
            Console.WriteLine("Lütfen bir limti giriniz: ");
            user_limit = Convert.ToInt32(Console.ReadLine());
            while (counter <= user_limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                counter++;
            }

            //Do-While Bölümü önce bir kere çalışır ve ardından koşul sağlanırsa çalışmaya devam eder. Fakat While bölümü koşul sağlanırsa çalışmaya başlar. Bu nedenle
            //Do-While bölümü bir kere çalışırken While bölümü çalışmaya başlamaz.

        }
    }
}