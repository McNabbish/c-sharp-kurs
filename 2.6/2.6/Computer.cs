using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Computer
    {
        Random RNG = new Random();
        int guess;
        int number;
        public int nGuess;
        private bool lost;
        private bool won;

        public Computer()
        {
            number = RNG.Next(0, 101);
            nGuess = 0;
            lost = false;
            won = false;
        }

        public void MakeGuess()
        {
            while (lost == false && won == false)
            {
                Console.WriteLine("make your {0} guess", nGuess+1);

                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Input error: {0}", e);
                }

                if (guess == number)
                {
                    Console.WriteLine("Congtatulations you won in {0} guesses, correct number was {1}", nGuess + 1, number);
                    won = true;
                    Console.WriteLine("To play again press Y key");
                    if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                    {
                        Console.Clear();
                        number = RNG.Next(0, 101);
                        nGuess = 0;
                        lost = false;
                        won = false;
                    }
                }
                else if (guess < number)
                {
                    nGuess++;
                    Console.WriteLine("{0} is to low, you have {1} remaning", guess, (7 - nGuess));
                }

                else
                {
                    nGuess++;
                    Console.WriteLine("{0} is to high, you have {1} remaning", guess, (7 - nGuess));
                }

                if (nGuess == 7 && won == false)
                {
                    Console.WriteLine("Sorry, you lost, number was {0}, to play again press Y to play again or N to exit",number);
                    if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                    {
                        Console.Clear();
                        number = RNG.Next(0, 101);
                        nGuess = 0;
                        lost = false;
                        won = false;
                    }

                    else
                        lost = true;

                }
            }
        }

    }
}
