using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Assignment_PHILIP_GRAHAM
{
    class Program
    {
        static void Main(string[] args)
        {
            stages();







            Hurricane();







            /// Dice Game
            Random generator = new Random();
            double bankAccount = 100;
            int die1 = generator.Next(1, 7);
            int die2 = generator.Next(1, 7);

            Console.WriteLine("Welcome to the dice game, you will be able to bet on one of four possibilities with your choose of how much you want to bet");
            Console.WriteLine("Please enter what outcome you want to bet on (Doubles ENTER 1 to win 2x your bet) (Not doubles ENTER 2 to win 1.5x your bet) (Even Sum ENTER 3 win your bet) (Odd Sum ENTER 4 win your bet )");
            int betRoll;
            while (!Int32.TryParse(Console.ReadLine(), out betRoll))
                Console.WriteLine("Invalid Input");
            Console.WriteLine("Please enter the amount you want to bet (Maximum 100$)");
            double betAmount;
            while (!double.TryParse(Console.ReadLine(), out betAmount))
                Console.WriteLine("Invalid Input");
            Console.WriteLine($"The first die rolled was {die1}, the second was {die2}");
            if ((die1) == (die2) && (betRoll) == 1)
            {
                bankAccount = ((bankAccount) + (betAmount * 2));
                Console.WriteLine($"You have {bankAccount} dollars");
            }
            else if (die1 != die2 && betRoll == 1)
            {
                bankAccount = (bankAccount - betAmount);
                Console.WriteLine($"You have {bankAccount} dollars");
            }
            else if (die1 != die2 && betRoll == 2)
            {
                bankAccount = ((bankAccount) + (betAmount * 1.5));
                Console.WriteLine($"You have {bankAccount}");


            }
            else if (die1 == die2 && betRoll == 2)
            {
                bankAccount = ((bankAccount) + (bankAccount - betAmount));
                Console.WriteLine($"You have {bankAccount} dollars");

            }
           else if ((die1 + die2 == 2 || die1 + die2 == 4 || die1 + die2 == 6|| die1 + die2 == 8 || die1 + die2 == 10|| die1 + die2 == 12)  && betRoll == 3)
            {
                bankAccount = (bankAccount + betAmount);
                Console.WriteLine($"You have {bankAccount} dollars");

            }    
            else if ((die1 + die2 != 2 || die1 +die2 != 4 || die1 + die2 != 6 || die1 + die2  != 8|| die1 + die2 != 10 || die1 + die2 != 12) && betRoll == 3 )
            {
                bankAccount = bankAccount - betAmount;
                Console.WriteLine($"You have {bankAccount} dollars");

            }
            else if ((die1 + die2 == 3 || die1 + die2 == 5 || die1 + die2 == 7 || die1 + die2 == 9 || die1 + die2 == 11) && betRoll == 4 )
            {
                bankAccount = (bankAccount + betAmount);
                Console.WriteLine($"You have {bankAccount} dollars");

            }

            else if ((die1 + die2 != 3 || die1 + die2 != 5 || die1 + die2 != 7 || die1 + die2 != 9 || die1 + die2 != 11) && betRoll == 4 )
            {
                bankAccount = (bankAccount + betAmount);
                Console.WriteLine($"You have {bankAccount} dollars");

            }








            Console.ReadLine();






























        }
        public static void stages()
        {
            Console.WriteLine("Please enter your age");
            int age;
            while (!Int32.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Invalid Input");

            if (age > 18)
                Console.WriteLine("Adult");

            else if (age <= 18 && age > 12)
                Console.WriteLine("Teen");


            else if (age <= 12 && age > 10)
                Console.WriteLine("Preteen");


            else if (age <= 10 && age > 5)
                Console.WriteLine("Child");


            else if (age <= 5 && age > 0)
                Console.WriteLine("Toddler");
        }
        public static void Hurricane()
        {
            Console.WriteLine("Pleaase Enter a Hurricane Category (1-5)");
            int category;
            while (!Int32.TryParse(Console.ReadLine(), out category))
                Console.WriteLine("Invalid Input");


            switch (category)
            {
                case 1:
                    Console.WriteLine($"The speed of the hurricane is between 74-95 mph");
                    break;
                case 2:
                    Console.WriteLine($"The Speed of the hurricane is between 96-110 mph");
                    break;
                case 3:
                    Console.WriteLine($"The Speed of the hurricane is between 111-130 mph");
                    break;
                case 4:
                    Console.WriteLine($"The Speed of the hurricane is between 131-155 mph");
                    break;

                case 5:
                    Console.WriteLine($"The Speed of the hurricane is greater than 155 mph");
                    break;
            }


        }
    }
}
