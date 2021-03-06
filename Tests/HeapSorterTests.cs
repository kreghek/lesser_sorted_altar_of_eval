﻿using System;
using Algo.Sorters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class HeapSorterTests
    {
        /// <summary>
        /// 1. В системе есть массив из 3 элементов, удовлетворяющий основному свойству кучи (A[Parent(i)]>A[i]).
        /// 2. Поддерживаем кучу.
        /// 3. Куча не изменилась.
        /// </summary>
        [Test]
        public void Heapify_HasHeapProperty_ReturnsSameHeap()
        {
            //ARRANGE

            var sorter = new HeapSorter();
            var a = new[] { 6, 3, 1 };
            var heap = new Heap { A = a, HeapSize = a.Length };


            // ACT

            sorter.Heapify(heap, 0);



            //ASSERT

            var parent = a[0];
            var left = a[1];
            var right = a[2];
            AssertHelper.ArrayIsHeap(parent, left, right);
        }

        /// <summary>
        /// 1. В системе есть массив из 3 элементов. Не поддерживает свойство кучи (левый потомок больше родителя).
        /// 2. Поддерживаем кучу.
        /// 3. Куча стала поддерживать свойтсво кучи.
        /// </summary>
        [Test]
        public void Heapify_LeftIsGreater_ReturnsHeapProperty()
        {
            //ARRANGE

            var sorter = new HeapSorter();
            var a = new[] { 3, 5, 1 };
            var heap = new Heap { A = a, HeapSize = a.Length };


            // ACT

            sorter.Heapify(heap, 0);



            //ASSERT

            var parent = a[0];
            var left = a[1];
            var right = a[2];
            AssertHelper.ArrayIsHeap(parent, left, right);
        }

        /// <summary>
        /// 1. В системе есть массив из 3 элементов. Не поддерживает свойство кучи (правый потомок больше родителя).
        /// 2. Поддерживаем кучу.
        /// 3. Куча стала поддерживать свойтсво кучи.
        /// </summary>
        [Test]
        public void Heapify_RightIsGreater_ReturnsHeapProperty()
        {
            //ARRANGE

            var sorter = new HeapSorter();
            var a = new[] { 3, 1, 5 };
            var heap = new Heap { A = a, HeapSize = a.Length };


            // ACT

            sorter.Heapify(heap, 0);



            //ASSERT

            var parent = a[0];
            var left = a[1];
            var right = a[2];
            AssertHelper.ArrayIsHeap(parent, left, right);
        }
    }
}
