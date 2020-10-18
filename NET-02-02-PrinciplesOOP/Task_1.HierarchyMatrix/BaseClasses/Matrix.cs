// <copyright file="Matrix.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_02_PrinciplesOOP
{
    using System;

    public abstract class Matrix<T>
    {
        protected Matrix(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            this.Matrice = new MatrixCell<T>[height, width];
        }

        protected Matrix(MatrixCell<T>[,] matrice)
        {
            this.Height = matrice.GetLength(0);
            this.Width = matrice.GetLength(1);
            this.Matrice = matrice;
        }

        public MatrixCell<T>[,] Matrice { get; set; }

        public int Width
        {
            get;
            private set;
        }

        public int Height
        {
            get;
            private set;
        }

        public MatrixCell<T> this[int x, int y]
        {
            get
            {
                return this.Matrice[x, y];
            }

            set
            {
                this.Matrice[x, y] = value;

                // Fires some event.
                Console.WriteLine("Placeholder Event.");
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            var retMat = a;
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    a[i, j] = a[i, j] + b[i, j];
                }
            }

            return retMat;
        }
    }
}
