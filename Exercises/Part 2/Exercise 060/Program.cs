using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
      PrintTriangle(4);
    }


    public static void PrintStars(int number)
    {
      int count = 0;
      while (count != number)
      {
        Console.Write("*");
        count++;
      }
      Console.WriteLine("");

      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
      for (int count = 0; count != size; count++)
      {
          PrintStars(size);
      }
    
    }

    public static void PrintRectangle(int width, int height)
    {
      int count = 0;
      while (count < height)
      {
          PrintStars(width);
          count++;
      } 
    
    }
     
    public static void PrintTriangle(int size)
    {
      int number = 1;
      while (number <= size)
      {
        PrintStars(number);
         number++;
      }
      
       
    }
 } 

}
     
      
        
    
      
  
  


