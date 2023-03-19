using System;

namespace TheTechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            // Print "The Tech Academy" and "Student Daily Report."
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // Ask for and save student information.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needsHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyHours = int.Parse(Console.ReadLine());

            // Print thank you message.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
