// <copyright file="UnitTestGeometricHierarchy.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_01_BasicsOOPTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NET_02.Task_2.GeometricHierarchy;
    using NUnit;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTestGeometricHierarchy
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Triangle_Test_Creating()
        {
            var accuracy = 0.001;
            var shape = new Triangle(3, 4, 5);

            Assert.AreEqual(6, shape.GetArea(), accuracy);
            Assert.AreEqual(12, shape.GetPerimeter(), accuracy);
        }

        [Test]
        public void Rectangle_Test_Creating()
        {
            var accuracy = 0.001;
            var shape = new Rectangle(3, 4);

            Assert.AreEqual(12, shape.GetArea(), accuracy);
            Assert.AreEqual(14, shape.GetPerimeter(), accuracy);
        }

        [Test]
        public void Square_Test_Creating()
        {
            var accuracy = 0.001;
            var shape = new Square(3);

            Assert.AreEqual(9, shape.GetArea(), accuracy);
            Assert.AreEqual(12, shape.GetPerimeter(), accuracy);
        }

        [Test]
        public void Circle_Test_Creating()
        {
            var accuracy = 0.01;
            var shape = new Circle(12);

            Assert.AreEqual(452.389, shape.GetArea(), accuracy);
            Assert.AreEqual(75.3982, shape.GetPerimeter(), accuracy);
        }
    }
}
