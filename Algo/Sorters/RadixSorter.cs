﻿using System;

namespace Algo.Sorters
{
    public sealed class RadixSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            throw new NotImplementedException();
        }

        public class RadixCountingSorter : CountingSorter
        {
            public RadixCountingSorter(int radix): base(9)
            {

            }

            protected override int GetSortValue(int sourceValue)
            {
                return base.GetSortValue(sourceValue);
            }
        }
    }
}
