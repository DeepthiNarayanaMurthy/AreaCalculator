using System;
namespace AreaCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice\n1.Circle\n2.Rectangle\n3.Triangle");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter the dimension in same line");
            string input = Console.ReadLine();
            double[] dimensions = Array.ConvertAll(input.Split(' '), double.Parse);
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape shape = shapeFactory.GetShape(choice,dimensions);
            string result=shape.CalculateArea().Display();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
