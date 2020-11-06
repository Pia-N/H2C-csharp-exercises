using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string first = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string second = Console.ReadLine();
      bool ifStringsEqual = first == second;
      if (ifStringsEqual)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
          Console.WriteLine("Nope!");
      }
    }
  }
}
