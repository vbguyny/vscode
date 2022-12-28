using System;

namespace ZeldaAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("Welcome to the Legend of Zelda: Breath of the Wild!");
            Console.WriteLine("You are Link, a brave hero on a quest to defeat the evil Ganon and save the kingdom of Hyrule.");
            Console.WriteLine("You have just arrived at the entrance to the Great Plateau, the starting point of your journey.");
            Console.WriteLine("You see a sign that reads: ");
            Console.WriteLine("'Use the power of the Sheikah Slate to defeat the guardians and reach the Shrine of Resurrection.'");
            Console.WriteLine();

            // Main game loop
            while (true)
            {
                // Display options
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Explore the Great Plateau");
                Console.WriteLine("2. Use the Sheikah Slate");
                Console.WriteLine("3. Quit the game");
                // Get player input
                int choice = int.Parse(Console.ReadLine());

                // Perform action based on player input
                if (choice == 1)
                {
                    Console.WriteLine("You venture out into the Great Plateau, searching for clues and treasure.");
                    Console.WriteLine("You come across a group of bokoblins, fierce monsters that guard valuable loot.");
                    Console.WriteLine("Do you want to fight them or try to sneak past them?");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Sneak past");

                    int action = int.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        Console.WriteLine("You draw your sword and engage the bokoblins in battle.");
                        Console.WriteLine("After a fierce fight, you emerge victorious and claim your prize - a treasure chest filled with rupees.");
                    }
                    else if (action == 2)
                    {
                        Console.WriteLine("You try to sneak past the bokoblins, but one of them spots you and raises the alarm.");
                        Console.WriteLine("You are forced to fight them, but you manage to defeat them and claim your prize - a treasure chest filled with rupees.");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You use the Sheikah Slate to locate and activate the Shrine of Resurrection.");
                    Console.WriteLine("As you approach the shrine, you are confronted by a guardian, a powerful ancient robot that protects the shrine.");
                    Console.WriteLine("Do you want to try to defeat the guardian or turn back?");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Turn back");
                    // Get player input
                    choice = int.Parse(Console.ReadLine());

                    // Perform action based on player input
                    if (choice == 1)
                    {
                        Console.WriteLine("You venture out into the Great Plateau, searching for clues and treasure.");
                        Console.WriteLine("You come across a group of bokoblins, fierce monsters that guard valuable loot.");
                        Console.WriteLine("Do you want to fight them or try to sneak past them?");
                        Console.WriteLine("1. Fight");
                        Console.WriteLine("2. Sneak past");

                        int action = int.Parse(Console.ReadLine());
                        if (action == 1)
                        {
                            Console.WriteLine("You draw your sword and engage the bokoblins in battle.");
                            Console.WriteLine("After a fierce fight, you emerge victorious and claim your prize - a treasure chest filled with rupees.");
                        }
                        else if (action == 2)
                        {
                            Console.WriteLine("You try to sneak past the bokoblins, but one of them spots you and raises the alarm.");
                            Console.WriteLine("You are forced to fight them, but you manage to defeat them and claim your prize - a treasure chest filled with rupees.");
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("You use the Sheikah Slate to locate and activate the Shrine of Resurrection.");
                        Console.WriteLine("As you approach the shrine, you are confronted by a guardian, a powerful ancient robot that protects the shrine.");
                        Console.WriteLine("Do you want to try to defeat the guardian or turn back?");
                        Console.WriteLine("1. Fight");
                        Console.WriteLine("2. Turn back");


                        int action = int.Parse(Console.ReadLine());
                        if (action == 1)
                        {
                            Console.WriteLine("You draw your weapons and engage the guardian in battle.");
                            Console.WriteLine("After a fierce fight, you emerge victorious and enter the shrine, where you find a powerful artifact - the Spirit Orb.");
                            Console.WriteLine("You place the Spirit Orb in the altar, and the shrine disappears, transporting you to the next location on your journey.");
                        }
                        else if (action == 2)
                        {
                            Console.WriteLine("You decide to turn back, not wanting to risk your life against such a powerful foe.");
                            Console.WriteLine("You return to the entrance of the Great Plateau, where you can make a different choice.");
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You decide to quit the game. Thank you for playing!");
                    break;
                }
            }
            }
        }
    }



