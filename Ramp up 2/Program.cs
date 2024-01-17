using System;

public class RampUp2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("====================================================\n\t\t\t\t   GULENG, SEAN KENNETH SORIANO.\n====================================================");
        double updateWeight, updateLength, updateFah;

        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Weights in Pounds (lbs): ");
            string userWeight = Console.ReadLine();

            try
            {
                updateWeight = double.Parse(userWeight);
                double resultKilo = updateWeight * 0.45359237;
                Console.WriteLine($"Weight Converted to Kilo (kg): {resultKilo}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
                validInput = false;
            }
        }
        //===========END OF THE WEIGHT CONVERTER=============//

        validInput = false;
        while (!validInput)
        {
            Console.Write("Length in Miles (mi): ");
            string userLength = Console.ReadLine();

            try
            {
                updateLength = double.Parse(userLength);
                double resultMiles = updateLength * 1.609344;
                Console.WriteLine($"Length in Kilometers (km): {resultMiles}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
            }
        }
        //===========END OF THE LENGTH CONVERTER=============//

        validInput = false;
        while (!validInput)
        {
            Console.Write("Temperature in Fahrenheit (*F): ");
            string userFah = Console.ReadLine();

            try
            {
                updateFah = double.Parse(userFah);
                double resultCelcius = (updateFah - 32) * 5 / 9;
                Console.WriteLine($"Temperature in Celsius (*C): {resultCelcius}\n====================================================\n");
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! PLEASE ENTER NUMBERS ONLY!");
            }
        }
        //===========END OF THE TEMPERATURE CONVERTER=============//

        validInput = false;
        while (!validInput)
        {
            try
            {
                double sum = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Age of Student {i}: ");
                    string studentAgeInput = Console.ReadLine();

                    double studentAge = double.Parse(studentAgeInput);
                    sum += studentAge;
                }

                double average = sum / 10;
                Console.WriteLine($"The average age of the Students is: {average:F2}\n====================================================\n");

                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(">>INVALID INPUT! NUMBERS ONLY!");
            }
        }
        //===========END OF THE AVERAGE AGE OF STUDENT=============//

        //===Characters===//
        string char1 = "Sean";
        string char2 = "Girmille";
        string char3 = "Esteven";
        string char4 = "Elton";
        string char5 = "Brent";
        //===Weapons===//
        string weaponSean = "Royal Claymore";
        string weaponGirmille = "Ethereal Longbow";
        string weaponElton = "Cresent Blades";
        string weaponEsteven = "Arcane Scepter";
        string weaponBrent = "Verdant Halberd";
        //===Ability===//
        string abSean = "Aegis Strike";
        string abGirmille = "Celestial Volley";
        string abElton = "Shadow Dance";
        string abEsteven = "Nova Blast";
        string abBrent = "Earthern embrace";

        //===Story===//
        Console.WriteLine($"In the majestic realm of veloria, a kingdom embroiled in the echoes of ancient battles, five valiant knights rose to defend there land. {char1} 'The Stalwart leader' (equipped with {weaponSean}), a mighty sword from the metal of the astral forge. sean's {abSean} allowed him to create a protective barrier, sheilding his comrades in the battlefield.\n");
        Console.WriteLine($"{char2}, 'The swift and precise elf knight' wielded {weaponGirmille} weapon imbued with the power of the Silvermoon. Girmille's unmatched marksmanship and the {abGirmille} allowed her to rain arrows in the air with uncanny accuracy.{char3}, 'The nimble rouge knight fought with {weaponElton} known for its dazzling agility. His {abElton} rendered him elusive, allowing him to weave through enemy ranks unseen, delivering swift strikes from the shadows.{char4} 'The sorcerer knight', carried the {weaponEsteven} a staff crackling with the energies of the Arcane Rift. His magical prowess and the {abEsteven} unleashed devastating bursts of arcane power, scattering adversaries on the battlefield.{char5}, 'The wise druid' bore the {weaponBrent} polearm adorned the nature's blessings. with the {abBrent}, Brent could summon entangling vines and roots to immobilize foes, turning the tide of the battle in favor of Valoria. Together, these five knights stood as the vanguard of the kingdom, their weapons and abilities weaving a tapestry of defense against any threat that dared to challenge the sovereignty of Valoria.'\n");

            validInput = false;
        while (!validInput)
        {
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();

            if (int.TryParse(userNum, out int n))
            {
                if (n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int o = 1; o <= i; o++)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine();
                        validInput = true;
                    }
                    Console.WriteLine("====================================================\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter  valid a integer.");
                validInput = false;
            }
        }
        //===========END OF THE PATTERN 1=============//


        validInput = false;
        while (!validInput)
        {
            Console.Write("Enter a number: ");
            string userNum = Console.ReadLine();

            if (int.TryParse(userNum, out int userNumber))
            {
                if (userNumber <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.\n");
                }
                else
                {
                    int sum = 0;
                    Console.Write("Formula: ");
                    for (int i = 1; i <= userNumber; i++)
                    {
                        sum += i;
                        Console.Write(i);
                        if (i < userNumber)
                        {
                            Console.Write(" + ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Output: {sum}");
                    validInput = true;
                    Console.WriteLine("====================================================\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                validInput = false;
            }
        }
        //===========END OF THE PATTERN 2=============//
        validInput = false;
        while (!validInput)
        {
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();

            if (int.TryParse(userNum, out int n))
            {
                if (n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                else
                {
                    for (int i = n; i >= 1; i--)
                    {
                        for (int o = 1; o <= i; o++)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine();
                        validInput = true;
                    }
                    Console.WriteLine("====================================================\n\t\t\t\tEND OF THE ACTIVITY\n====================================================");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                validInput = false;
            }
        }
        //===========END OF THE PATTERN 3=============//
        //===========THE END THANKS <3<3=============//
    }
}