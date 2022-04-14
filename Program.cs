using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double result = Rectangle(284,264) - Triangle(84,264) + Rectangle(180,106);
      double cost = result * 180;
      Console.WriteLine($"Total Cost : {Math.Round(cost,2)}"); 
    }
    static double Rectangle(double a, double b)
    {
      return a*b;
    }
    static double Circle(double radius)
    {
      return (Math.PI)*(Math.Pow(radius,2));
    }
    static double Triangle(double a, double b)
    {
      return 0.5*a*b;
    } 
  }
}
