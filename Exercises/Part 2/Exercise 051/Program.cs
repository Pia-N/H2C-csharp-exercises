using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      
      
      // Call your method here:
      PrintUntilNumber(5);
     
    }

    // Write your method here:
  public static void PrintUntilNumber(int number)
  {
    int count = 1;
    do
    {
        Console.WriteLine(count);
        count++;
    }
     while (count <= number);
  }
  
  }
}
