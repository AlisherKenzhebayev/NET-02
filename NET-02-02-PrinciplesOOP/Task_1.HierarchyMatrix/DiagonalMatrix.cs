// <copyright file="DiagonalMatrix.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_02_PrinciplesOOP
{
    using System;

    public class DiagonalMatrix<T> : SquareMatrix<T>, IDiagonalMatrix
    {
        private string mException = "Matrix is not diagonal.";
        public DiagonalMatrix(int height, int width)
            : base(height, width)
        {
            if (this.CheckIsDiagonal())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public DiagonalMatrix(MatrixCell<T>[,] m)
            : base(m)
        {
            if (this.CheckIsDiagonal())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public bool CheckIsDiagonal()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    if (i != j)
                    {
                        if (!this.Matrice[i, j].Value.Equals(default(T)))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
