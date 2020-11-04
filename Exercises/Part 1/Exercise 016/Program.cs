using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      int userInt = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(60*60*24* (userInt));

    }
  }
}
