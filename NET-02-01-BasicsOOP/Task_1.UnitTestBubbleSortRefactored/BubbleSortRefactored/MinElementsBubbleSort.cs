// <copyright file="MinElementsBubbleSort.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02
{
    using System;
    using System.Linq;

    public class MinElementsBubbleSort : IBubbleSortArrayRows
    {
        public void DoSortRows(int[][] array, Modes mode)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (this.Helper(array[j], array[j + 1], mode))
                    {
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
        }

        private bool Helper(int[] f, int[] s, Modes mode)
        {
            if (mode == Modes.Ascending)
            {
                return f.Min() > s.Min();
            }
            else
            {
                return f.Min() < s.Min();
            }
        }
    }
}
