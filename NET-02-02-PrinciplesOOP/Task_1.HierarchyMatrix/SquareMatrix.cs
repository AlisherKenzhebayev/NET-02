// <copyright file="SquareMatrix.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_02_PrinciplesOOP
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class SquareMatrix<T> : Matrix<T>, ISquareMatrix
    {
        private string mException = "Matrix is not square.";

        public SquareMatrix(int height, int width)
            : base(height, width)
        {
            if (this.CheckIsSquare())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public SquareMatrix(MatrixCell<T>[,] m)
            : base(m)
        {
            if (this.CheckIsSquare())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public bool CheckIsSquare()
        {
            return this.Width == this.Height;
        }
    }
}
