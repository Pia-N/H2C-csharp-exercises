using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int start = Convert.ToInt32(Console.ReadLine());
      int end = Convert.ToInt32(Console.ReadLine());
      DivisibleByThreeInRange(start, end);
      

    }

    // Write your method here:
     public static void DivisibleByThreeInRange(int start, int end)
     {
      while (start <= end)
      {
      if((start % 3) == 0)
          {
            Console.WriteLine(start);
          } 
          start++;
      }
      
          
      }
     }
         
      

         


          
  }
}      
          
    
    
      
    

       
  

     

