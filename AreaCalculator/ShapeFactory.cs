using System;
namespace AreaCalculator
{
    public class ShapeFactory
    {
        
        public Shape GetShape(string choice,params double[] list)
        {
            //public const string circle = "circle";
            //Console.WriteLine("Enter your choice\n1.Circle\n2.Rectangle\n3.Triangle");
           // int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case "circle":
                    Circle circle=new Circle(list);
                    return circle;
                    
                case "rectangle":
                    Rectangle rectangle=new Rectangle(list);
                    return rectangle;
                   
                case "triangle":
                    Triangle triangle=new Triangle(list);
                    return triangle;
                    
                default:
                    throw new Exception("Incorrect Shape");

            }
        }
    }
}
