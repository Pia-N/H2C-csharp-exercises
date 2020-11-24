using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int userNumber = Convert.ToInt32(Console.ReadLine());
      int numberOftimes = 0;

      while(userNumber > numberOftimes)
      {
        PrintPhrase();
        numberOftimes++;
      }  
 
    } // Write your method here:
    public static void PrintPhrase() 

    {
      Console.WriteLine("In a hole in the ground there lived a method");  
    }
     
    
  }
}
