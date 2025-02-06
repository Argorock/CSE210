// using System;
// using System.Diagnostics.Metrics;
// using System.Formats.Asn1;

// namespace Shapes;
// public class Rectangle
// {
//     // Attribute
//     private double _width;
//     private double _height;

//     // Contructors
//     public Rectangle()
//     {
//         _Initialize();
//         _width = 0;
//         _height = 0;
//     }

//     public Rectangle(double width, double height)
//     {
//         _Initialize();
//         _width = width;
//         _height = height;
//     }

//     private void _Initialize()
//     {
//         _width = new Measurement();
//         _height = new Measurement();
//     }

//     public void setWidth(double width)
//     {
//         if (width < 0)
//         {
//             Console.WriteLine("Bad width");
//             return;
//         }
//     }

//     public void setHeight(double height)
//     {
//         if (height < 0)
//         {
//             Console.WriteLine("Bad height");
//             return;
//         }
//     }

//     public double GetArea(double width, double height)
//     {
//         double area = width * height;
//         return area;
//     }

//     public void SetMetric()
//     {
//         _width.SetMetric(flag);
//         _height.Setmetric(flag);
//     }
//     public void Display()
//     {
//         Console.WriteLine($"Rectangle: {_width}, {_height}");
//     }
// }