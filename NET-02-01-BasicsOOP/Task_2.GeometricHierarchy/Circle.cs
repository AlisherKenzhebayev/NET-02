// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02.Task_2.GeometricHierarchy
{
    using System;

    public class Circle : IShapes
    {
        public Circle(double r)
        {
            this.Radius = r;
        }

        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
