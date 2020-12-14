using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Write something.");
      while (true)
      {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        if (input == "")
        {
          break;
        }
        for (int i = 0; i < parts.Length; i++)
        {
         
        }
         Console.WriteLine(parts[parts.Length-1]);
      }

    }
      //public static void PrintLastWord(string[] words, string last)
      //{
      //string first = words[0];
      //foreach (var word in words)
      //{
        //if(first <= words.Length && last >= words.Length)
        //{
          //Console.WriteLine(last);
        //}
          
  }
}




