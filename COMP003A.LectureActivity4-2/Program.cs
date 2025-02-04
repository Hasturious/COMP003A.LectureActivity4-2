// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Practice implementing methods in C#

namespace COMP003A.LectureActivity4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetUser();

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            
            int sum = CalculateSum(num1, num2);
            Console.WriteLine($"the sum of {num1} and {num2} is {sum}");

            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array contents:");
            DisplayArray(numbers);
        }
        static void GreetUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the Methods Activity.");
        }

        /// <summary>
        /// Calculates the sum of two numbers and returns the result.
        /// </summary>
        /// <parum name="num1">Interger Input Number 1</parum>
        /// <parum name="num2">Interger Input Number 2</parum>
        /// <returns>Interger sum of the two interger inputs</returns>
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
