using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your birth year:");
      int userAge = Convert.ToInt32(Console.ReadLine());
      if (userAge < 1900)
      {
        Console.WriteLine("You're old.");

      }
      
    }
  }
}
