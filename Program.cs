using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTeacher
{
    class Program
    {
        public static string AppName = "Algorithm Teacher";
        public static string AppVer = "0.0.1";
        public static string AppDeveloper = "Adam Poole";
        public static List<AlgorithmBase> algorithms;

        static void Main(string[] args)
        {
            algorithms = new List<AlgorithmBase>();
            algorithms.Add(new GradeSchoolMultiplicationAlgorithm());

            // Display app info - App name, app version, author.
            PrintAppInfo();

            // Greet user
            PrintAppIntro();

            // Display choices
            PrintChoicesList(algorithms);

            while (true)
            {
                Console.Write("Enter an algorithm number (or ? for the list of choices): ");
                string input = Console.ReadLine();

                // User wants to quit
                if (input == "q" || input == "Q")
                {
                    break;
                }

                // User wants to see choices again
                if (input == "?")
                {
                    PrintChoicesList(algorithms);
                    continue;
                }

                int inputNo;
                // If anything other than a number is entered,
                if(!Int32.TryParse(input, out inputNo))
                {
                    // Tell the user what is considered a valid entry then ask to enter an option
                    PrintErrorMessage("Please enter a number for an algorithm, q to quit, or ? to see the options again.");
                    continue;
                }

                // If a negative number or 0 is entered,
                if (inputNo <= 0)
                {
                    // Tell the user to enter a number greater than 0 then ask to enter an option
                    PrintErrorMessage("Please enter number greater than 0, or enter ? to see the options again.");
                    continue;
                }

                // If a number outside the list of choices is entered,
                if (inputNo > algorithms.Count)
                {
                    // Tell the user they must enter a number from the list of choices then ask to enter an option
                    PrintErrorMessage("Please enter a number corresponding to an algorithm option, or enter ? to see the options again.");
                    continue;
                }

                // Input options start from 1, list index starts from 0. So grab the list item at input number - 1.
                algorithms[inputNo - 1].StartAlgorithm();
            }

            PrintColourMessage("Thanks for using the Algorithm Teacher, bye.", ConsoleColor.Green);
        }

        // Prints a message to the console in the given colour, then resets colour to white.
        public static void PrintColourMessage(String message, ConsoleColor textColour)
        {
            Console.ForegroundColor = textColour;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Prints an error message to the console in red, then resets colour to white.
        public static void PrintErrorMessage(String message)
        {
            PrintColourMessage(message, ConsoleColor.Red);
        }

        static void PrintAppInfo()
        {
            string appInfo = $"{AppName}: Version {AppVer} created by {AppDeveloper}";
            PrintColourMessage(appInfo, ConsoleColor.Green);
        }

        static void PrintAppIntro()
        {
            string appIntro = "Welcome to the Algorithm Teacher app. This application is designed to describe several" +
                " different algorithms" +
                "\nand demonstrate how they work step-by-step with example cases to help you better understand them.";
            Console.WriteLine(appIntro);
        }

        // Show a list of input options
        // - Each option is a number linked to an algorithm
        // - A list of algorithm classes is accessed to get the size of the options. Each class should give an algorithm's name that can be displayed here.
        // - An extra option 'Q' is added to quit the program.
        // - Another option '?' is added
        static void PrintChoicesList(List<AlgorithmBase> algorithms)
        {
            Console.WriteLine("Options List");
            int i = 1;
            foreach(AlgorithmBase algorithm in algorithms) {
                Console.WriteLine(i + " - " + algorithm.GetName());
                i++;
            }

            Console.WriteLine("? - Display options");
            Console.WriteLine("q - Quit application");
        }
    }
}
