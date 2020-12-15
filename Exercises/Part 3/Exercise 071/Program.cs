using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      Console.WriteLine("Give a list of numbers(-1 stops). Then search for index");
     
      while (true)
        {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
        }
        Console.WriteLine("Search for?");
        int answer = Convert.ToInt32(Console.ReadLine());
        int index = list.IndexOf(answer);
        
        for (int i = 0; i < list.Count; i++)
        {
          int number = list[i];
        if (answer == number)
        {
          Console.WriteLine(answer +" is at index "+i);
        }
        }
        Console.WriteLine("Number not found on given list.");
    }
  }
}

