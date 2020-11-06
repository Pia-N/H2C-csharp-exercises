using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 -100]");
      int number1 = Convert.ToInt32(Console.ReadLine());
      if (number1 < 0)
      {
        Console.WriteLine("Impossible!");
      }
      else if (number1 <= 49 )
      {
          Console.WriteLine("Fail.");
      }
      else if (number1 <= 59)
      {
          Console.WriteLine("Your grade is: 1");
      }
      else if (number1 <= 69)
      {
          Console.WriteLine("Your grade is: 2");
      }
      else if (number1 <= 79)
      {
          Console.WriteLine("Your grade is: 3");
      }
      else if (number1 <= 89)
      {
          Console.WriteLine("Your grade is: 4");
      }
      else if (number1 <= 100)
      {
          Console.WriteLine("Your grade is: 5");
      }
      else
      {
          Console.WriteLine("Outstanding!");
      }
    }
  }
}
