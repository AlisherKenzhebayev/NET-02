// <copyright file="JaggedArraySortableByRows.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class JaggedArraySortableByRows : IArraySortableByRows
    {
        public int[][] Array { get; set; }

        public void SortAscendingOrder(MaxElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Ascending);
        }

        public void SortDescendingOrder(MaxElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Descending);
        }

        public void SortAscendingOrder(MinElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Ascending);
        }

        public void SortDescendingOrder(MinElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Descending);
        }

        public void SortAscendingOrder(SumElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Ascending);
        }

        public void SortDescendingOrder(SumElementsBubbleSort sort)
        {
            sort.DoSortRows(this.Array, Modes.Descending);
        }
    }
}
