// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02.Task_2.GeometricHierarchy
{
    using System;
    using System.Runtime.CompilerServices;

    public class Triangle : IShapes
    {
        public Triangle(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public double GetArea()
        {
            var s = this.GetPerimeter() / 2;
            return Math.Sqrt(s * (s - this.X) * (s - this.Y) * (s - this.Z));
        }

        public double GetPerimeter()
        {
            return this.X + this.Y + this.Z;
        }
    }
}
