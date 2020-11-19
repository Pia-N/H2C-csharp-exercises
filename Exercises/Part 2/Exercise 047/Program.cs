using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int endNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int startNum = Convert.ToInt32(Console.ReadLine());

      while (startNum <= endNum)
      {
        Console.WriteLine(startNum);
        startNum++;  
      }
      
    }
    
      
            
    
  }
}
