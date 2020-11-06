using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number:");
      int number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number:");
      int number2 = Convert.ToInt32(Console.ReadLine());
      if (number1 > number2)
      {
        Console.WriteLine("The larger number is "+number1 +"!");

      }
      else if (number2 > number1)
      {
           Console.WriteLine("The larger number is "+number2 +"!");
      }
      else
      {
          Console.WriteLine("They are equal!");
      }
    }
  }
}
         
