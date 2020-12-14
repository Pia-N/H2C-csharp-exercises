using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
   {
      Console.WriteLine("Tell a story:");
      while (true)
      {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        
        if(input == " ")
          { 
           break;
          }
        for (int i = 0; i < words.Length; i++)
        { 
          Console.WriteLine(words[i]);
        //foreach (var word in words)
        //{
          //Console.WriteLine(word);
        //}
        }
      }
    }
  }
}




