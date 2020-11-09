using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      
      while (true)    
      {
        Console.WriteLine("Give a number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 0)  
        {
          break;
        }
        if (userNumber < 0)
        {
          Console.WriteLine("That is negative.");
          continue;
        }
        if (userNumber > 0)
        {
          int answer = userNumber*userNumber;
          Console.WriteLine(answer);
        }
        
      }
    }
  }
}

    

