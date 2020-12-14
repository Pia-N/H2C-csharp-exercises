using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Write something.");
      while (true)
      {
        string input = Console.ReadLine();
        string[] pieces = input.Split(' ');
        if (input == "")
        {
          break;
        }
        for (int i = 0; i < pieces.Length; i++)
        {
          if (pieces[i].Contains("av")) 
          {
            Console.WriteLine(pieces[i]);
          }    
        }
        




          
      }

    }

  }

}

