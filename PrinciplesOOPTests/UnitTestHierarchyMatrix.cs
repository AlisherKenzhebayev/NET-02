namespace PrinciplesOOPTests
{
    using NUnit.Framework;
    using System;
    using NET_02_02_PrinciplesOOP;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Symmetric_Matrix_Test_Exception()
        {
            var mat = new MatrixCell<int>[,] 
            {
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(4) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
            };
            Assert.Throws<Exception>(() => new SymmetricMatrix<int>(mat));
        }


        [Test]
        public void Symmetric_Matrix_Test_Pass()
        {
            var mat = new MatrixCell<int>[,]
            {
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
            };
            Assert.DoesNotThrow(() => new SymmetricMatrix<int>(mat));
        }

        [Test]
        public void Diagonal_Matrix_Test_Exception()
        {
            var mat = new MatrixCell<int>[,]
            {
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(4) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(5) , new MatrixCell<int>(5) , new MatrixCell<int>(5) },
            };
            Assert.Throws<Exception>(() => new DiagonalMatrix<int>(mat));
        }

        [Test]
        public void Diagonal_Matrix_Test_Exception_Not_Square()
        {
            Assert.Throws<Exception>(() => new DiagonalMatrix<int>(3, 4));
        }

        [Test]
        public void Diagonal_Matrix_Test_Pass()
        {
            var mat = new MatrixCell<int>[,]
            {
                { new MatrixCell<int>(5) , new MatrixCell<int>(0) , new MatrixCell<int>(0) },
                { new MatrixCell<int>(0) , new MatrixCell<int>(5) , new MatrixCell<int>(0) },
                { new MatrixCell<int>(0) , new MatrixCell<int>(0) , new MatrixCell<int>(5) },
            };
            Assert.DoesNotThrow(() => new DiagonalMatrix<int>(mat));
        }

        [Test]
        public void Square_Matrix_Test_Exception()
        {
            Assert.Throws<Exception>(() => new SquareMatrix<int>(3, 4));
        }

        [Test]
        public void Square_Matrix_Test_Exception_V_2()
        {
            var mat = new MatrixCell<int>[,]
            {
                { new MatrixCell<int>(5) , new MatrixCell<int>(0) },
                { new MatrixCell<int>(0) , new MatrixCell<int>(5) },
                { new MatrixCell<int>(0) , new MatrixCell<int>(0) },
            };
            Assert.Throws<Exception>(() => new SquareMatrix<int>(mat));
        }
    }
}