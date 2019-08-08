using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPlayer, inputComputer;
            int randInput;

            bool playAgain = true;            

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreComputer = 0;

                while (scoreComputer < 3 && scorePlayer < 3)
                {
                    Console.Write("Choose option Rock, Paper, Scissor.... ");
                    inputPlayer = Console.ReadLine();

                    Random random = new Random();
                    randInput = random.Next(1, 4);

                    switch (randInput)
                    {
                        case 1:
                            inputComputer = "Rock";
                            Console.WriteLine("Computer chooses Rock");
                            if (inputPlayer.ToUpper() == "Rock".ToUpper())
                            {
                                Console.Write("Draw!!!!\n");
                            }
                            else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                            {
                                Console.Write("Player Wins!!!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.Write("Computer Wins!!!!\n");
                                scoreComputer++;
                            }
                            else
                            {
                                Console.Write("Invalid Input [" + inputPlayer + "]\n");
                            }
                            break;
                        case 2:
                            inputComputer = "Paper";
                            Console.WriteLine("Computer chooses Paper");
                            if (inputPlayer.ToUpper() == "Rock".ToUpper())
                            {
                                Console.WriteLine("Computer Wins!!!!\n");
                                scoreComputer++;
                            }
                            else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                            {
                                Console.Write("Draw!!!!\n");
                            }
                            else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.Write("Player Wins!!!\n");
                                scorePlayer++;
                            }
                            else
                            {
                                Console.Write("Invalid Input [" + inputPlayer + "]\n");
                            }
                            break;
                        case 3:
                            inputPlayer = "Scissor";
                            Console.WriteLine("Computer chooses Scissor");
                            if (inputPlayer.ToUpper() == "Rock".ToUpper())
                            {
                                Console.Write("Player Wins!!!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                            {
                                Console.Write("Computer Wins!!!!\n");
                                scoreComputer++;
                            }
                            else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.Write("Draw!!!!\n");
                            }
                            else
                            {
                                Console.Write("Invalid Input [" + inputPlayer + "]\n");
                            }
                            break;
                        default:
                            Console.Write("Invalid Entry");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}\n", scorePlayer, scoreComputer);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Wins!!!");
                }
                else if (scoreComputer == 3)
                {
                    Console.WriteLine("Compurter Wins!!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?? Enter Y or N: ");
                string loop = Console.ReadLine();

                if (loop == "y" || loop == "Y")
                {
                    playAgain = true;
                }
                else if (loop == "n" || loop == "N")
                {
                    playAgain = false;
                }

            }


        }
    }
}
