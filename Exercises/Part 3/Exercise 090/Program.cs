using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    { Console.WriteLine("Give name, age (empty line exits):");
      int oldest = 0;
      while (true)
      {
        string input = Console.ReadLine();
       
       if (input != "")
        {
          string [] nameAndAge = input.Split(',');
          int age = Convert.ToInt32(nameAndAge[1]);
        
        if (oldest < age)
        
           oldest = age;
        }
        else
        {
           Console.WriteLine("Age of the oldest: " +oldest);
           break; 
        }

      }
     
       
      

        

    }    
        
  }
}




