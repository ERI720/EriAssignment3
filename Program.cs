using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EriAssignment3
{
    public abstract class Shape
    {
        protected double width;
        protected double height;


        public Shape(double Width)
        {
            width = height = Width;
        }
        public Shape(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public abstract double CalculateSurface();
    }

    public class Rectangle : Shape
    {
        public Rectangle(double Width, double Height) : base(Width, Height)
        {


        }
        public override double CalculateSurface()
        {
            return height * width;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double Width, double Height) : base(Width, Height)
        {


        }
        public override double CalculateSurface()
        {
            return height * width / 2;
        }
    }
    public class Circle : Shape
    {
        public Circle(double Radius) : base(Radius)
        {


        }
        public override double CalculateSurface()
        {
            return 3.142 * width * width;
        }
    }
   public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Triangle(4, 6.3));
            list.Add(new Rectangle(5, 21));
            list.Add(new Circle(11.2));




            Console.WriteLine($"Area of Triangle: {list[0].CalculateSurface()}");
            Console.WriteLine($"Area of Rectangle: {list[1].CalculateSurface()}");
            Console.WriteLine($"Area of Circle: {list[2].CalculateSurface()}");
            Console.ReadKey();
        }
    }
}
