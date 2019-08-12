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
            //playerName-gets the player name as input, inputPlayer-gets the  option R/P/S from user, inputComputer- CPU choise
            String playerName, inputPlayer, inputComputer;
            int randInput;

            bool playAgain = true;

            Console.Write("Enter your name:- ");
            playerName = Console.ReadLine();

            //To get the player name
            if (playerName.Trim()==null || playerName.Trim()=="")
            {
                playerName = "Player";
            }

            //To loop the game after a certain score is achieved
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreComputer = 0;

                //Loop the game untill a particular score (3) achieved
                while (scoreComputer < 3 && scorePlayer < 3)
                {
                    Console.Write("Choose option Rock, Paper, Scissor.... ");
                    inputPlayer = Console.ReadLine();

                    //Get a random input by CPU
                    Random random = new Random();
                    randInput = random.Next(1, 4);

                    //Based on the random number generator (switch the Rock,Paper,Scissor options)
                    switch (randInput)
                    {
                        //Implementaion if computer chooses Rock
                        case 1:
                            inputComputer = "Rock";

                            if (inputPlayer.ToUpper() == "Rock".ToUpper() || inputPlayer.ToUpper() == "Paper".ToUpper() || inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.WriteLine("Computer chooses Rock");
                            }
                            
                            if (inputPlayer.ToUpper() == "Rock".ToUpper())
                            {
                                Console.Write("Draw!!!!\n");
                            }
                            else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                            {
                                Console.Write(playerName +" Wins!!!\n");
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

                        //Implementaion if computer chooses Paper
                        case 2:
                            inputComputer = "Paper";
                            if (inputPlayer.ToUpper() == "Rock".ToUpper() || inputPlayer.ToUpper() == "Paper".ToUpper() || inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.WriteLine("Computer chooses Paper");
                            }
                            
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
                                Console.Write(playerName + " Wins!!!\n");
                                scorePlayer++;
                            }
                            else
                            {
                                Console.Write("Invalid Input [" + inputPlayer + "]\n");
                            }
                            break;

                        //Implementaion if computer chooses Scissor
                        case 3:
                            inputComputer = "Scissor";
                            if (inputPlayer.ToUpper() == "Rock".ToUpper() || inputPlayer.ToUpper() == "Paper".ToUpper() || inputPlayer.ToUpper() == "Scissor".ToUpper())
                            {
                                Console.WriteLine("Computer chooses Scissor");
                            }
                            
                            if (inputPlayer.ToUpper() == "Rock".ToUpper())
                            {
                                Console.Write(playerName + " Wins!!!\n");
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

                        //Default switch implementation
                        default:
                            Console.Write("Invalid Entry");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\t{0}:\t{1}\tCPU:\t{2}\n",playerName, scorePlayer, scoreComputer);
                }

                //Get the input from user, to continue play again the game after certain score is reahed
                if (scorePlayer == 3)
                {
                    Console.WriteLine(playerName + " Wins!!!");
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
