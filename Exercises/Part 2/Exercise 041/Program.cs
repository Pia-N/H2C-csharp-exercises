using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      Console.WriteLine("Give a number:");
      int inputNumber = Convert.ToInt32(Console.ReadLine());
      int result = inputNumber * inputNumber;
      Console.WriteLine(result);
     
    }
  }
}
