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
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSort_Sort_ReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 5, 1, 4, 2, 8 };
            int[] expected = new int[] { 1, 2, 4, 5, 8 };

            //Act
            ISortable<int> selectionSort = new SelectionSort<int>(unsorted);
            int[] actual = selectionSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void SelectionSort_Sort_SortedDescReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            //Act
            ISortable<int> selectionSort = new SelectionSort<int>(unsorted);
            int[] actual = selectionSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
