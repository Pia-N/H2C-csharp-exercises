using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      int userNumber = Convert.ToInt32(Console.ReadLine());
      int result = userNumber* -1;
      if(userNumber < 0)
      {
        Console.WriteLine(result);
      }
      else
      {
        Console.WriteLine(userNumber);
      }

      
    }
  }
}
