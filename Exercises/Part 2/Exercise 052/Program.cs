using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int num = Convert.ToInt32(Console.ReadLine());
      PrintFromNumberToOne(num);

    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
  {
    int count = 1;
    do
    {
        Console.WriteLine(number);
        number--;
    }
     while (count <= number);
  }
  

  }
}
