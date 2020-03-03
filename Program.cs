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
            bool drinks;
            bool underage;
            bool isAlcoholic;
            int handicap;

            // if (age >= legalAge)
            // {
            //     Console.WriteLine("DRINK DRINK DRINK");
            // }
            // else if (age >= 16)
            // {
            //     Console.Write("DRINK DRINK DRINK........then get in trouble ");
            //     Console.WriteLine("and drop out of school!");
            // }
            // else
            // {
            //     Console.WriteLine("DRINK DRINK DRINK........then get in trouble");
            //     Console.WriteLine("And stay in school, damnit.");
            // }

            if (age < legalAge) {
                underage = true;
            }
            else {
                underage = false;
            }

            drinks = new Program().Drinks();

            if (underage && drinks) {
                handicap = 4;
            }
            else if (drinks) {
                handicap = 2;
            }
            else {
                handicap = 0;
            }

            isAlcoholic = new Program().IsAlcoholic(handicap);
            
            if (underage && isAlcoholic) {
                Console.WriteLine("Congrats, you're now an alcoholic child.");
            }
            else if (underage) {
                Console.WriteLine("You're still pure, kid.");
            }
            else if (isAlcoholic) {
                Console.WriteLine("You done fucked up, big fella. You're now an alcoholic.");
            }
            else {
                Console.WriteLine("Drink on..........for now.");
            }
        }

        bool Drinks() {
            int selection = 0;
            int attempts = 0;
            while (attempts < 3) {
                Console.WriteLine("You have been offered alcohol.\nWill you drink it?");
                Console.WriteLine("1. Gimme.\n2. Hell no.");
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection >= 1 && selection <= 2) {
                    break;
                }
                Console.WriteLine("\nInvalid selection.");
                attempts++;
            }
            
            if (selection == 2) return false;
            else return true;
        }

        bool IsAlcoholic(int handicap) {
            if (handicap == 0) {
                return false;
            } 
            else {
                Random random = new Random();

                int chances = random.Next(handicap, 10);

                if (chances >= 5) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
    }
}
