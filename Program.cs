using System;

namespace IntroProgSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int legalAge = 18;

            if (age >= legalAge) {
                Console.WriteLine("DRINK DRINK DRINK");
            }
            else {
                Console.WriteLine("DRINK DRINK DRINK........then get in trouble");
            }
        }
    }
}
