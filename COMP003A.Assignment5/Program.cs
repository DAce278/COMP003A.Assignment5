namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays text
            IntroMessage("Welcome to the Program Organizer!\n");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int num = int.Parse(Console.ReadLine());

        }
        static void IntroMessage(string message)
        {
            // first message
            Console.WriteLine(message);
        }
    }
}
