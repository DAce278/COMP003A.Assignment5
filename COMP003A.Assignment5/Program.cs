using System.Reflection.Metadata;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // displays beginning text
            IntroMessage("Welcome to the Program Organizer!\n");

            // user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int num = int.Parse(Console.ReadLine());

            // calculation results
            int constant = 5;
            int result = AgeCalculation(num, constant);
            Console.WriteLine($"Calculated Value: {result}");
        }
        static void IntroMessage(string message)
        {
            // first message
            Console.WriteLine(message);
        }
        static int AgeCalculation(int num, int constant)
        {
            return num + constant;
        }
    }
}
