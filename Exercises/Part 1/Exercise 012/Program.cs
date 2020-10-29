using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Writeline("Give a number!");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.Writeline("You gave" + userInput);


    }
  }
}
