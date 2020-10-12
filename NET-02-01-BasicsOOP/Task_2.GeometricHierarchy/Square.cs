// <copyright file="Square.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02.Task_2.GeometricHierarchy
{
    using System;
    using System.Runtime.CompilerServices;

    public class Square : IShapes
    {
        public Square(double x)
        {
            this.X = x;
        }

        public double X { get; set; }

        public double GetArea()
        {
            return this.X * this.X;
        }

        public double GetPerimeter()
        {
            return this.X * 4;
        }
    }
}
