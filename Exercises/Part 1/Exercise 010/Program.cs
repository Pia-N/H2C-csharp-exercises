using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:

            Console.WriteLine("I will tell a story, but I need some information.\nGive a name for the main character:");

            String name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            String title = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine($"Once upon a time there was a {title} called {name}.");
            Console.WriteLine($"On her/his way to work,{name} often pondered what being a {title} meant to them.");
            Console.WriteLine($"When you work as a {title} you meet interesting people.");
            Console.WriteLine($"{name} enjoys her/his work as a {title}.The end.");


        }
    }
}
