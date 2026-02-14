using System.Reflection.Metadata;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // displays beginning text
            IntroMessage("Welcome to the Program Organizer!");

            while (true)
            {


                // user input
                Console.Write("\n\nEnter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());


                // calculation results
                int constant = 5;
                int result = AgeCalculation(age, constant);
                Console.WriteLine($"\nCalculated Value: {result}");

                // evaluation
                if (result > 20)
                {
                    Console.WriteLine("Your number is greater than 20");
                }
                else
                {
                    Console.WriteLine("Your number is less than or equal to 20");
                }

                // user input for repetition
                Console.Write("\nWould you like to restart the program? (y/n): ");

            }
        }
        static void IntroMessage(string message)
        {
            // first message
            Console.Write(message);
        }
        static int AgeCalculation(int age, int constant)
        {
            // calculation adding 5 to age
            return age + constant;
        }
    }
}
