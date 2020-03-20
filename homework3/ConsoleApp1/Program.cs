using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Shape
    {
        double Area();
        bool IsCorrect();
    }
    public class Rectangle:Shape
    {
        public int Width { set; get; }
        public int Height { set; get; }
        public Rectangle(int width,int height)
        {
            Width = width;
            Height = height;
            if (!IsCorrect())
                Width = Height = 0;
        }
        public double Area()
        {
            return Width * Height;
        }
        public bool IsCorrect()
        {
            if (Width > 0 && Height > 0)
                return true;
            else
                return false;
        }
    }
    public class Square:Rectangle
    {
        public Square(int side) : base(side, side) { }
    }
    public class Triangle:Shape
    {
        private int Width { set; get; }
        private int Height { set; get; }
        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;
            if (!IsCorrect())
                Width = Height = 0;
        }
        public double Area()
        {
            return Width * Height / 2;
        }
        public bool IsCorrect()
        {
            if (Width > 0 && Height > 0)
                return true;
            else
                return false;
        }
    }
    class ShapeFactory
    {
        public static Shape GetShape(int type, Random random)
        {
            Shape shape;
            switch (type)
            {
                case 0:
                    shape = new Rectangle(random.Next(1, 10), random.Next(1, 10));
                    break;
                case 1:
                    shape = new Square(random.Next(1, 10));
                    break;
                default:
                    shape = new Triangle(random.Next(1, 10), random.Next(1, 10));
                    break;
            }
            Console.WriteLine(shape.GetType() + " " + shape.Area());
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[10];
            Random random = new Random();
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int type = random.Next(0, 3);
                shapes[i] = ShapeFactory.GetShape(type, random);
                sum += shapes[i].Area();
            }
            Console.WriteLine("面积之和：" + sum) ;
        }
    }
}
