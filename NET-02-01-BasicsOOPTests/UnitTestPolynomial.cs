// <copyright file="UnitTestPolynomial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_01_BasicsOOPTests
{
    using NET_02.Task_3.Polynomials;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTestPolynomial
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Polynomial_Test_Equality()
        {
            var a = new Polynomial(new int[] { 1, 2, 3 });
            var b = new Polynomial(new int[] { 1, 2, 3 });

            Assert.AreEqual(a, b);
        }

        [Test]
        public void Polynomial_Test_Sum()
        {
            var a = new Polynomial(new int[] { 1, 2, 3 });
            var b = new Polynomial(new int[] { 1, 2, 3, 4 });
            var c = a + b;

            var res = new Polynomial(new int[] { 2, 4, 6, 4 });
            Assert.AreEqual(res, c);
        }

        [Test]
        public void Polynomial_Test_Sub()
        {
            var a = new Polynomial(new int[] { 2, 3, 4 });
            var b = new Polynomial(new int[] { 1, 2, 3, 4 });
            var c = a - b;

            var res = new Polynomial(new int[] { 1, 1, 1, -4 });
            Assert.AreEqual(res, c);
        }
    }
}
