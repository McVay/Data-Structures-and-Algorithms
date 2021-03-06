﻿using DSandAlgorithms.Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DSandAlgorithmsTests.Algorithms.Sorting
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            int[] input = new int[] { 40, 34, 500, 100, 43, 43, 65 };
            System.Collections.Generic.List<int> sorted = input.OrderBy(s => s).ToList();

            BubbleSort.Sort(input);

            CollectionAssert.AreEqual(sorted, input);
            Assert.AreEqual(500, input[input.Length - 1]);
        }
    }
}