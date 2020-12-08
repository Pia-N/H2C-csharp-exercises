using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
        Console.WriteLine("Search for?");
        string nameSearch = Console.ReadLine();
        if(list.Contains(nameSearch))
        {
          Console.WriteLine(nameSearch+ " was found!");
        }
        else
        {
            Console.WriteLine(nameSearch+ " was not found!");
        }

    }
  }
}

