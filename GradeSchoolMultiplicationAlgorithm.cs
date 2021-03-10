using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTeacher
{
    class GradeSchoolMultiplicationAlgorithm : AlgorithmBase
    {
        private int defaultX = 1234;
        private int defaultY = 5678;

        public GradeSchoolMultiplicationAlgorithm()
        {
            string name = "Grade School Multiplication Algorithm";
            string algVers = "1.0";

            string intro = "The grade school multiplication algorithm is a simple algorithm for solving the problem of integer multiplication.\n" +
                "In integer multiplication you have 2 non-negative integers, x and y, which you want the product of.\n" +
                "The grade school algorithm is the method taught in grade school for calculating this product.";

            string description = "The grade school multiplication algorithm takes as input two non-negative integers, x and y. You take the integer\n" +
                "x, separate out the digits, tens, hundreds, etc. that make it up and then multiply each by the integer y.\n" +
                "Finally, you add together the results and this gives you the product x * y.";

            string pseudocode = "Grade School Multiplication Algorithm Pseudocode\n" +
                "Split x into units, tens, hundreds, etc\n" +
                "For each unit, ten, hundred, etc.:\n" +
                "   Multiply it by y\n" +
                "Sum the results";

            SetName(name);
            SetAlgVers(algVers);
            SetIntro(intro);
            SetDescription(description);
            SetPseudocode(pseudocode);
        }

        public override void DisplayAlgorithmDefaultCase()
        {
            Console.WriteLine("In the default case for this algorithm we will be using x = 1234 and y = 5678.");
            Console.WriteLine("The first step is to separate out the units, tens, hundreds, etc. in x.");

            List<int> xNumbers = SeparateNumber(defaultX);

            Console.WriteLine("When we separate the units, tens, etc., in 1234 we get:");
            foreach (int number in xNumbers) {
                Console.WriteLine(number);
            }

            Console.WriteLine("Next we multiply each of these separated numbers by y, 5678.");

            List<int> multipliedXNumbers = MultiplyNumbers(xNumbers, defaultY);

            Console.WriteLine("This gives:");
            foreach (int number in multipliedXNumbers) {
                Console.WriteLine(number);
            }

            Console.WriteLine("Finally, we add up all these products to get the total.");

            int total = TotalNumberList(multipliedXNumbers);

            Console.WriteLine("This gives " + total);
            Console.WriteLine("Thus, using the grade school multiplication algorithm, the product of 1234 * 5678 is " + total);
        }

        private List<int> SeparateNumber(int number)
        {
            int i = 10;
            List<int> separatedNumbers = new List<int>();

            while (number > (i / 10))
            {
                separatedNumbers.Add((number % i) - (number % (i / 10)));
                i *= 10;
            }

            return separatedNumbers;
        }

        private List<int> MultiplyNumbers(List<int> numbers, int multiplier)
        {
            List<int> multipliedNumbers = new List<int>();

            foreach (int number in numbers)
            {
                multipliedNumbers.Add(number * multiplier);
            }

            return multipliedNumbers;
        }

        private int TotalNumberList(List<int> numbers)
        {
            int total = 0;

            foreach(int number in numbers) {
                total += number;
            }

            return total;
        }
    }
}
