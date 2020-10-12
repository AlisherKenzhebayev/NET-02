// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02.Task_2.GeometricHierarchy
{
    using System;
    using System.Runtime.CompilerServices;

    public class Rectangle : IShapes
    {
        public Rectangle(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double GetArea()
        {
            return this.X * this.Y;
        }

        public double GetPerimeter()
        {
            return (this.X + this.Y) * 2;
        }
    }
}
