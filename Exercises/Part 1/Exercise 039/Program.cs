using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while (true)    
      {
        Console.WriteLine("Exit with 0. Give a number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 0)  
        {
          break;
        }
        if (userNumber != 0) 
        {
        sum = sum + userNumber;
        }
      }  
    Console.WriteLine("Total sum of numbers: "+sum);
    }
  }
}
