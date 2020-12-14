using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string name = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string passWord = Console.ReadLine();
      string userName1 = "alex";
      string userName2 = "emma";
      string passWord1 = "sunshine";
      string passWord2 = "haskell";

     
      while (true)
      {
       if (passWord == passWord1 && name == userName1)
      {
        Console.WriteLine("You have successfully logged in!");
        break;
      }
      else if (passWord == passWord2 && name == userName2)
      {
        Console.WriteLine("You have successfully logged in!");
        break;
      }
        else
      {
       Console.WriteLine("Incorrect username or password!");
       break;
      }
      }
     
      
      
     
      
     
    
        
      


    }
  }
}

