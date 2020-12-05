using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      ChristmasTree(6);
    }

    public static void PrintStars(int number)
    {
       int count = 0;
      while (count < number)
      {
        Console.Write("*");
        count++;
      }
      Console.WriteLine("");

    }

    public static void PrintSpaces(int number)
    { int count = 0;
      while (count < number)
      {
         Console.Write(" ");
         count++; 
      }

    }

    public static void PrintRightTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(size-i);
        PrintStars(i);
      }
      
    }

    public static void ChristmasTree(int height)
    { // to deduct the spaces we need to minus from the amount of times
    //the loop runs and is checking the height value
   
    for (int i = 0; i <= height; i++)
  
      {
        PrintSpaces(height-i);
        PrintStars(i*2-1);
      }
        int lastRow = ((height*2)-3)/2;
      for (int i = 0; i < 2; i++)
      {
          PrintSpaces(lastRow);
          PrintStars(3);
      }   


    }
  }
}
