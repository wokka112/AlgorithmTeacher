using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTeacher
{
    abstract class AlgorithmBase
    {
        private string name;
        private string algVers;

        public AlgorithmBase()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAlgVers()
        {
            return algVers;
        }

        public void SetAlgVers(string algVers)
        {
            this.algVers = algVers;
        }

        public void StartAlgorithm()
        {
            // Display the algorithm's info
            DisplayAlgorithmInfo();

            // Give a quick intro for the algorithm
            DisplayAlgorithmIntro();

            // Show available user choices
            DisplayChoicesMenu();

            // Start menu loop
            while (true)
            {
                Console.WriteLine("Enter an option (or ? to show the available options again):");
                string input = Console.ReadLine();

                if (input == "p" || input == "P")
                {
                    Program.PrintColourMessage("Returning to main menu.", ConsoleColor.Green);
                    break;
                }

                if (input == "?")
                {
                    DisplayChoicesMenu();
                    continue;
                }

                int inputNo;
                if (!Int32.TryParse(input, out inputNo))
                {
                    Program.PrintErrorMessage("Please enter an option number, ? to display the options again or p to return to the previous menu.");
                }

                switch (inputNo)
                {
                    case 1:
                        DisplayAlgorithmDescription();
                        break;
                    case 2:
                        DisplayAlgorithmPseudoCode();
                        break;
                    case 3:
                        DisplayAlgorithmDefaultCase();
                        break;
                    default:
                        Program.PrintErrorMessage("Please enter an option number between 1 and 3 (inclusive), or ? if you would like to see the options again.");
                        break;
                }
            }
        }

        // Display the name and version of the algorithm
        private void DisplayAlgorithmInfo()
        {
            Program.PrintColourMessage("Algorithm: " + GetName() + ". Version: " + GetAlgVers(), ConsoleColor.Green);
        }

        // Give a brief intro for the algorithm - what problem it solves
        private void DisplayAlgorithmIntro()
        {
            Console.WriteLine("Intro TBA");
        }

        private void DisplayChoicesMenu()
        {
            Console.WriteLine("1 - Display Algorithm description");
            Console.WriteLine("2 - Display Algorithm Pseudocode");
            Console.WriteLine("3 - Demonstrate the Algorithm");
            // Should I add an option 4 where you can input your own data to be used
            // Should I add a couple extra default cases?
            Console.WriteLine("? - Show choices again");
            Console.WriteLine("p - Return to the previous menu");
        }

        // Give a detailed description of the algorithm, including how it works
        private void DisplayAlgorithmDescription()
        {
            Console.WriteLine("Description TBA");
        }

        // Give the pseudocode behind the algorithm
        private void DisplayAlgorithmPseudoCode()
        {
            Console.WriteLine("Pesudocode TBA");
        }

        // Run through the algorithm using default inputs and displaying appropriate steps to show how it works
        private void DisplayAlgorithmDefaultCase()
        {
            Console.WriteLine("Default case TBA");
        }
    }
}
