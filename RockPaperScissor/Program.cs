using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPlayer, inputComputer;
            int randInput;
            int scorePlayer = 0;
            int scoreComputer = 0;

            Console.Write("Choose option Rock, Paper, Scissor.... ");
            inputPlayer = Console.ReadLine();

            Random random = new Random();
            randInput = random.Next(1, 4);

            switch (randInput)
            {
                case 1:
                    inputComputer = "Rock";
                    if (inputPlayer.ToUpper() == "Rock".ToUpper())
                    {
                        Console.WriteLine("Draw!!!!\n\n");
                    }
                    else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                    {
                        Console.WriteLine("Player Wins!!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                    {
                        Console.WriteLine("Computer Wins!!!!\n\n");
                        scoreComputer++;
                    }
                    break;
                case 2:
                    inputComputer = "Paper";
                    if (inputPlayer.ToUpper() == "Rock".ToUpper())
                    {
                        Console.WriteLine("Computer Wins!!!!\n\n");
                        scoreComputer++;
                    }
                    else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                    {
                        Console.WriteLine("Draw!!!!\n\n");
                    }
                    else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                    {
                        Console.WriteLine("Player Wins!!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputPlayer = "Scissor";
                    if (inputPlayer.ToUpper() == "Rock".ToUpper())
                    {
                        Console.WriteLine("Player Wins!!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer.ToUpper() == "Paper".ToUpper())
                    {
                        Console.WriteLine("Computer Wins!!!!\n\n");
                        scoreComputer++;
                    }
                    else if (inputPlayer.ToUpper() == "Scissor".ToUpper())
                    {
                        Console.WriteLine("Draw!!!!\n\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}
