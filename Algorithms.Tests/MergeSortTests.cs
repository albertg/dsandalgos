using Algorithms.Interfaces;
using Algorithms.Sorting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void MergeSort_Sort_ReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 10, 80, 30, 90};
            int[] expected = new int[] { 10, 30, 40, 50, 70, 80, 90 };

            //Act
            ISortable<int> mergeSort = new MergeSort<int>(unsorted);
            int[] actual = mergeSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
