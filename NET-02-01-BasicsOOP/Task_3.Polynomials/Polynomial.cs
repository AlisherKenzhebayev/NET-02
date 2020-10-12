// <copyright file="Polynomial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02.Task_3.Polynomials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Microsoft.VisualBasic.CompilerServices;

    public class Polynomial
    {
        public Polynomial(int[] c)
        {
            this.Coefficients = c;
        }

        public int[] Coefficients { get; set; }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            var c = new int[Math.Max(a.Coefficients.Length, b.Coefficients.Length)];
            for (var i = 0; i < c.Length; i++)
            {
                c[i] = ((i < a.Coefficients.Length) ? a.Coefficients[i] : 0) + ((i < b.Coefficients.Length) ? b.Coefficients[i] : 0);
            }

            return new Polynomial(c);
        }

        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            var c = new int[Math.Max(a.Coefficients.Length, b.Coefficients.Length)];
            for (var i = 0; i < c.Length; i++)
            {
                c[i] = ((i < a.Coefficients.Length) ? a.Coefficients[i] : 0) - ((i < b.Coefficients.Length) ? b.Coefficients[i] : 0);
            }

            return new Polynomial(c);
        }

        public override string ToString()
        {
            var retstr = this.Coefficients[0].ToString();
            for (int i = 1; i < this.Coefficients.Length; i++)
            {
                retstr += "+" + this.Coefficients[i].ToString() + "*x^" + i.ToString();
            }

            return retstr;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Polynomial;
            if (item == null)
            {
                return false;
            }

            return this.ToString().Equals(item.ToString());
        }

        public override int GetHashCode()
        {
            return this.Coefficients.Sum();
        }
    }
}
