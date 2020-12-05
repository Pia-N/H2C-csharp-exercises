using System;
using System.Collections.Generic;


namespace exercise_63
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      
      
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
          break;
        }

        numbers.Add(input);
        
        
      }
      Console.WriteLine(numbers[1]+numbers[2]);
    }

  }
}
