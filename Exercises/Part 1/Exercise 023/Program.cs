using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());
      int sum = first + second;
      int minus = first - second;
      int multiply = first * second;
      double divide = (double)first / (double)second;
      Console.WriteLine((first) +"+" +(second) +"=" +(sum));
      Console.WriteLine((first) +"-" +(second) +"=" +(minus)); 
      Console.WriteLine((first) +"*" +(second) +"=" +(multiply));
      Console.WriteLine((first) +"/" +(second) +"=" +(divide)); 
       
      
       
      

    }
  }
}
