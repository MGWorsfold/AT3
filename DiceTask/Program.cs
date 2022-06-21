using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DiceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int dieSides;
            string menuSelection = "";
            string menu = "1. Roll dice \n2. Calculate average, total, or list all previous rolls \n3. Exit \n\n";
            string lineSeperator = "-----------------";
            List<int> diceRolls = new List<int>();
            ClGame C = new ClGame();

            while(menuSelection != "3")
            {
                int counter = 0;
                string rollAgain = "y";
                int numberDiceRolls = 0;

                Console.Write(menu);
                menuSelection = Console.ReadLine();
                Console.WriteLine(lineSeperator + "\n");
                switch(menuSelection)
                {
                    case "1":
                        while (rollAgain == "y" && numberDiceRolls <= 50 && numberDiceRolls >= 0)
                        {
                            Console.WriteLine("Do you want to use a six sided dice? (y/n)");
                            string dieSidesResponse = Console.ReadLine().ToLower();
                            if (dieSidesResponse == "y")
                            {
                                Die die = new Die();
                                dieSides = 6;
                            }
                            else
                            {
                                Console.WriteLine("how many sides would you like?");
                                dieSides = int.Parse(Console.ReadLine());
                                Die die = new Die(dieSides);
                            }

                            Console.WriteLine("How many dice would you like to roll?\n");
                            numberDiceRolls = int.Parse(Console.ReadLine());

                            Console.WriteLine(lineSeperator + "\n");

                            while(counter < numberDiceRolls)
                            {
                                Game.AddDie(dieSides);
                                counter++;
                            }

                            C.RollAllDice();

                            foreach(int i in C.Results)
                            {
                                Console.Write($"{i} ");
                            }

                            Console.WriteLine("\n");
                            Console.WriteLine("Would you like to roll again? (y/n)");
                            rollAgain = Console.ReadLine().ToLower();
                            if(rollAgain == "y")
                            {
                                counter = 0;
                            }
                            else
                            {
                                Console.WriteLine("\nSaving rolls");
                            }
                            Console.WriteLine("\n" + lineSeperator + "\n");
                        }
                        break;

                        case "2":
                            string caseTwoChoice = "";

                            while(caseTwoChoice != "D")
                            {
                                Console.WriteLine("A. Calculate average of rolls \nB. Calculate sum of rolls \nC. List all rolls \nD. Return to main menu \n");
                                caseTwoChoice = Console.ReadLine().ToUpper();
                                Console.WriteLine(lineSeperator);
                                switch(caseTwoChoice)
                                {
                                    case "A":
                                        double average = C.GetAverage();
                                        Console.WriteLine(average);
                                        Console.WriteLine($"{lineSeperator}\n");
                                        break;

                                    case "B":
                                        int total = C.GetTotal();
                                        Console.WriteLine(total);
                                        Console.WriteLine($"\n{lineSeperator}\n");
                                        break;

                                    case "C":
                                        foreach(int i in C.Results)
                                        {
                                            Console.Write($"{i} ");
                                        }
                                        Console.WriteLine($"\n\n{lineSeperator}\n");
                                        break;

                                    case "D":
                                        Console.WriteLine($"\nReturning to the main menu\n{lineSeperator}\n");
                                        break;
                                }
                            }
                            break;

                            case "3":
                                Console.WriteLine("Exiting program");
                                break;
                }
            }
        }
    }
}