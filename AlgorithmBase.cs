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

        private string intro;
        private string description;
        private string pseudocode;
        
        public AlgorithmBase()
        {

        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
        public string GetAlgVers() { return algVers; }
        public void SetAlgVers(string algVers) { this.algVers = algVers; }
        public string GetIntro() { return intro;  }
        public void SetIntro(string intro) { this.intro = intro; }
        public string GetDescription() { return description; }
        public void SetDescription(string description) { this.description = description; }
        public string GetPseudocode() { return pseudocode; }
        public void SetPseudocode(string pseudocode) { this.pseudocode = pseudocode; }

        public void StartAlgorithm()
        {
            // Display the algorithm's info
            DisplayAlgorithmInfo();

            // Give a quick intro for the algorithm
            DisplayAlgorithmIntro();

            // Show available user choices
            DisplayChoicesMenu();

            // Start menu loop
            RunMenuLoop();
        }

        // Display the name and version of the algorithm
        private void DisplayAlgorithmInfo()
        {
            Program.PrintColourMessage("Algorithm: " + GetName() + ". Version: " + GetAlgVers(), ConsoleColor.Green);
        }

        // Give a brief intro for the algorithm - what problem it solves
        public void DisplayAlgorithmIntro()
        {
            Console.WriteLine(GetIntro());
        }

        // This usually doesn't need overriding, but is included incase developers want to add more functionality to their algorithm menu.
        public virtual void DisplayChoicesMenu()
        {
            Console.WriteLine("1 - Display Algorithm description");
            Console.WriteLine("2 - Display Algorithm Pseudocode");
            Console.WriteLine("3 - Demonstrate the Algorithm");
            // Should I add an option 4 where you can input your own data to be used
            // Should I add a couple extra default cases?
            Console.WriteLine("? - Show choices again");
            Console.WriteLine("q - Quit to the previous menu");
        }

        // This usually doesn't need overriding, but is included incase developers want to add more functionality to their algorithm menu.
        public virtual void RunMenuLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter an option (or ? to show the available options again):");
                string input = Console.ReadLine();

                if (input == "q" || input == "Q")
                {
                    Program.PrintColourMessage("Quitting to main menu.", ConsoleColor.Green);
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
                    Program.PrintErrorMessage("Please enter an option number, ? to display the options again or q to quit to the previous menu.");
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

        // Give a detailed description of the algorithm, including how it works
        public void DisplayAlgorithmDescription()
        {
            Console.WriteLine(GetDescription());
        }

        // Give the pseudocode behind the algorithm
        public void DisplayAlgorithmPseudoCode()
        {
            Console.WriteLine(GetPseudocode());
        }

        // Run through the algorithm using default inputs and displaying appropriate steps to show how it works
        public virtual void DisplayAlgorithmDefaultCase()
        {
            Console.WriteLine("Default case TBA");
        }
    }
}
