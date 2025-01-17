/* 
   Author: Adam Verissimo
   Course: COMP-003A
   Faculty: Jonathan Cruz
   Purpose: COMP003A - Assignment 1
*/
namespace COMP003A_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hi, " + username + ". My name is Adam\n");

            Console.WriteLine("Here are 10 things about me:");
            Console.WriteLine("\t1. I am a C.I.S major at Lemoore College.");
            Console.WriteLine("\t2. I have experience with HTML, CSS, and JavaScript.");
            Console.WriteLine("\t3. This is my second semester here at Lemoore College.");
            Console.WriteLine("\t4. My current hobbies right now are playing video games or collecting Magic the Gathering cards.");
            Console.WriteLine("\t5. I have a girlfriend that I have been with for almost 3 years now.");
            Console.WriteLine("\t6. I plan on transferring to either Fresno State or Sacramento State.");
            Console.WriteLine("\t7. My dream car is a 2020 Dodge Challenger.");
            Console.WriteLine("\t8. Some genres of music I like are rap, alt-rock, R&B, and certain pop songs.");
            Console.WriteLine("\t9. I love to go fishing when I can.");
            Console.WriteLine("\t10. I enjoy ceramics, I hope to one day own my own potterswheel to do ceramic projects.");
        }
    }
}
