// <copyright file="UnitTestBubbleSortRefactored.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02_01_BasicsOOPTests
{
    using NET_02;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTestBubbleSortRefactored
    {
        private JaggedArraySortableByRows arrayVisitor;

        [SetUp]
        public void Setup()
        {
            this.arrayVisitor = new JaggedArraySortableByRows();
        }

        [Test]
        public void JaggedArraySortable_Test_MaxRow_Ascending()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.SortAscendingOrder(new MaxElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }

        [Test]
        public void JaggedArraySortable_Test_MaxRow_Descending()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.SortDescendingOrder(new MaxElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }

        [Test]
        public void JaggedArraySortable_Test_MinRow_Ascending()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.SortAscendingOrder(new MinElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }

        [Test]
        public void JaggedArraySortable_Test_MinRow_Descending()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.SortDescendingOrder(new MinElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }

        [Test]
        public void JaggedArraySortable_Test_SumRow_Ascending()
        {
            int[][] array =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.SortAscendingOrder(new SumElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }

        [Test]
        public void JaggedArraySortable_Test_SumRow_Descending()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            this.arrayVisitor.Array = array;

            int[][] expected =
            {
                new int[] { 7, 8, 9 },
                new int[] { 4, 5, 6 },
                new int[] { 1, 2, 3 },
            };

            this.arrayVisitor.SortDescendingOrder(new SumElementsBubbleSort());

            Assert.AreEqual(expected, this.arrayVisitor.Array);
        }
    }
}