using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me a string:");
      string answer = Console.ReadLine();
      string correctAnswer = "true";
      
      if (answer == correctAnswer)
      {
          Console.WriteLine("You got it right!");
      }
      else
      {
        Console.WriteLine("Try again!");
      }


    }
  }
}

