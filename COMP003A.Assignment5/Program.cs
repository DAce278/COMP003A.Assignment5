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

                Console.Write("Enter your number: ");
                int num = int.Parse(Console.ReadLine());


                // calculation results
                int constant = 5;
                int result = NumCalculation(num, constant);
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

               
                Console.Write("\nWould you like to restart the program? (y/n): ");

                // user input for repetition
                char yesNoLoop = char.Parse(Console.ReadLine());

                if (yesNoLoop == 'n')
                {
                    break;
                }

            }
        }
        static void IntroMessage(string message)
        {
            // first message
            Console.Write(message);
        }
        static int NumCalculation(int num, int constant)
        {
            // calculation adding 5 to num
            return num + constant;
        }
    }
}
