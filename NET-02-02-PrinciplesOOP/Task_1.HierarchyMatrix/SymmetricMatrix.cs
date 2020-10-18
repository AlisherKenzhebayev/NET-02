// <copyright file="SymmetricMatrix.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_02_PrinciplesOOP
{
    using System;
    using System.Collections.Generic;

    public class SymmetricMatrix<T> : SquareMatrix<T>, ISymmetricMatrix
    {
        private string mException = "Matrix is not symmetric.";

        public SymmetricMatrix(int height, int width)
            : base(height, width)
        {
            if (this.CheckIsSymmetric())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public SymmetricMatrix(MatrixCell<T>[,] m)
            : base(m)
        {
            if (this.CheckIsSymmetric())
            {
                // Do nothing
            }
            else
            {
                throw new Exception(this.mException);
            }
        }

        public bool CheckIsSymmetric()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    if (i != j)
                    {
                        if (!this.Matrice[i, j].Value.Equals(this.Matrice[j, i].Value))
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
