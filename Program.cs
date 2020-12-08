using System;
using System.Collections.Generic;

namespace CSharpRPS
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> rpsChoices = new List<string>();
            
            // GAME OPTIONS
            rpsChoices.Add("Rock");
            rpsChoices.Add("Paper");
            rpsChoices.Add("Scissors");

            // GAME SET TO NOT RUNNING
            bool running = false;

            // RANDOM CPU CHOICE
            Random randomizer = new Random();
            int randInt = randomizer.Next(0, 3);
            string cpuChoice = rpsChoices[randInt].ToLower(); 

            Console.WriteLine(@"Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Please type in what option you would like to play.");

            string userChoice = Console.ReadLine().ToLower();

            while (!running)
            {
                System.Console.WriteLine($"RESULTS:");
                running = true;
            }

            while(running)
            {
                switch(userChoice)
                {
                    case "rock":
                        Console.WriteLine($"You picked {userChoice}, and the computer picked {cpuChoice}.");
                        running = false;
                        break;
                    case "paper":
                        Console.WriteLine($"You picked {userChoice}, and the computer picked {cpuChoice}.");
                        running = false;
                        break;
                    case "scissors": 
                        Console.WriteLine($"You picked {userChoice}, and the computer picked {cpuChoice}.");
                        running = false;
                        break;
                    default: 
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }    
            }

            if(userChoice == cpuChoice)
            {
                Console.WriteLine("It's a tie.");
            } else if(userChoice == "rock" && cpuChoice == "paper")
            {
                Console.WriteLine("The computer won.");
            } else if(userChoice == "rock" && cpuChoice == "scissors")
            {
                Console.WriteLine("You won!");
            } else if(userChoice == "paper" && cpuChoice == "scissors")
            {
                Console.WriteLine("The computer won.");
            } else if(userChoice == "paper" && cpuChoice == "rock")
            {
                Console.WriteLine("You won!");
            } else if(userChoice == "scissors" && cpuChoice == "paper")
            {
                Console.WriteLine("You won!");
            } else if(userChoice == "scissors" && cpuChoice == "rock")
            {
                Console.WriteLine("The computer won.");
            }
        }
    }
}

