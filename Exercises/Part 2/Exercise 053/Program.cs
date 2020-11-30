using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
    int numerator = Convert.ToInt32(Console.ReadLine());
    int denominator = Convert.ToInt32(Console.ReadLine());
    Division(numerator,denominator);

    }

    // Write your method here:
     public static void Division(int numerator,int denominator) 
     {
      double result = ((double) numerator/(double)denominator);
      Console.WriteLine("The division of numbers "+numerator+ " and "+denominator+ " is "+result);
     }

    

  }
}
