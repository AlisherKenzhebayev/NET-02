// <copyright file="IArraySortableByRows.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NET_02
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IArraySortableByRows
    {
        void SortAscendingOrder(MaxElementsBubbleSort sort);

        void SortDescendingOrder(MaxElementsBubbleSort sort);

        void SortAscendingOrder(MinElementsBubbleSort sort);

        void SortDescendingOrder(MinElementsBubbleSort sort);

        void SortAscendingOrder(SumElementsBubbleSort sort);

        void SortDescendingOrder(SumElementsBubbleSort sort);
    }
}
