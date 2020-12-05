using System;
using System.Collections.Generic;


namespace exercise_62
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> names = new List<string>();
      Console.WriteLine("Give a list of names. Empty space ends.");
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }

        names.Add(input);
      }

      // BEGIN SOLUTION
      Console.WriteLine(names[2]);
      // END SOLUTION
    }

  }
}
