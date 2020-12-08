using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {
      List <int> numbers = new List<int>();
      Console.WriteLine("Give numbers, returns the sum, 0 quits");
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
          break;
        }
        numbers.Add(input);
      }
      

      Console.WriteLine("The sum is: "+Sum(numbers));
    }

      
     public static int Sum (List<int> numbers)
     {
       if (numbers.Count == 0)
       {
          return 0;
       }
       int sum = 0;
       foreach (int number in numbers)
       {
          sum = sum + number; 
       }
         return sum;

     }
    

  }

}


