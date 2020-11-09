using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int inputAmounts = 0;
      // Write your code here:
      while (true)    
      {
        Console.WriteLine("Give a number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 0)  
        {
          break;
        }
        else 
        {
        inputAmounts++;
        }
      }  
    Console.WriteLine("Total amount of numbers: "+inputAmounts);
    }
  }
}
