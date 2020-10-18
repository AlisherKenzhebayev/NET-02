// <copyright file="MatrixCell.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_02_PrinciplesOOP
{
    using System;

    public class MatrixCell<T>
    {
        public MatrixCell(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        /// <summary>
        /// This is an addition operation for MatrixCell, as T doesn't have one.
        ///  Might need some kind of delegate.
        /// </summary>
        public static MatrixCell<T> operator +(MatrixCell<T> a, MatrixCell<T> b)
        {
            throw new NotImplementedException();
        }
    }
}
