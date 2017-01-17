using System;
namespace AreaCalculator
{
    public abstract class Shape
    {
        public double area;
        public const double pi = 3.14;
        public abstract Shape CalculateArea();

        public abstract string Display();
        
    }
    public class Circle : Shape
    {
        public double radius;
        public Circle(params double[] list)
        {
            if (list.Length != 1)
                throw new Exception("Should pass only one radius");
            radius = list[0];
            if(radius<0 || radius > double.MaxValue)
                throw new Exception("Radius is out of range");
        }
        public override Shape CalculateArea()
        {
            //Console.WriteLine("Enter the radius");
            //double radius = double.Parse(Console.ReadLine());
            area = pi * radius * radius;
            return this;
        }
        public override string Display()
        {
            return "Area of the circle is "+this.area;
        }
    }
    public class Rectangle : Shape
    {
        public double length;
        public double breadth;
        public Rectangle(params double[] list)
        {
            if (list.Length != 2)
            {
                throw new Exception("Should have only 2 parameters");
            }
            length = list[0];
            breadth = list[1];
            if (length < 0||length>double.MaxValue)
                throw new Exception("Length is out of range");
            if (breadth < 0 || breadth > double.MaxValue)
                throw new Exception("Breadth is out of range");
        }
        public override Shape CalculateArea()
        {
            //Console.WriteLine("Enter the Length and breadth");
            //double length = double.Parse(Console.ReadLine());
            //double breadth = double.Parse(Console.ReadLine());
            area = length * breadth;
            return this;
        }

        public override string Display()
        {
                return "Area of the rectangle is " + this.area;
        }
    }
    public class Triangle : Shape
    {
        public double @base;
        public double height;
        public Triangle(params double[] list)
        {
            if (list.Length != 2)
            {
                throw new Exception("Should have only 2 parameters");
            }
            @base = list[0];
            height = list[1];
            if (@base < 0 || @base > double.MaxValue)
                throw new Exception("Base is out of range");
            if (height < 0 || height > double.MaxValue)
                throw new Exception("Height is out of range");
        }
        public override Shape CalculateArea()
        {
            //Console.WriteLine("Enter the base and height");
            //double @base = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            area = 0.5*@base * height;
            return this;
        }

        public override string Display()
        {
           
            return "Area of the triangle is " + this.area;
        }
    }
}
