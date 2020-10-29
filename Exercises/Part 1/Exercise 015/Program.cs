using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string userString = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      int userInt = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give a double:");
      double userDouble = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give a boolean:");
      bool userBoolean = Convert.ToBoolean(Console.ReadLine());
      Console.WriteLine("Your string:" + userString);
      System.Console.WriteLine("Your integer:" + userInt);
      System.Console.WriteLine("Your double:" + userDouble);
      System.Console.WriteLine("Your boolean:" + userBoolean);



    }
  }
}
