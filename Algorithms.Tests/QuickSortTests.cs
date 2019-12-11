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
    public class QuickSortTests
    {
        [Test]
        public void QuickSort_Sort_ReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            int[] expected = new int[] { 10, 30, 40, 50, 70, 80, 90 };

            //Act
            ISortable<int> quickSort = new QuickSort<int>(unsorted);
            int[] actual = quickSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void QuickSort_Sort_SortedDescReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            //Act
            ISortable<int> quickSort = new QuickSort<int>(unsorted);
            int[] actual = quickSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
