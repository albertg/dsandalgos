using Algorithms.Sorting;
using Algorithms.Interfaces;
using NUnit.Framework;

namespace Algorithms.Tests 
{
    [TestFixture]
    class InsertionSortTests 
    {
        [Test]
        public void InsertionSort_Sort_ReturnsSortedArray() 
        {
            //Arrange
            int[] unsorted = new int[] { 5, 1, 4, 2, 8 };
            int[] expected = new int[] { 1, 2, 4, 5, 8 };

            //Act
            ISortable<int> insertionSort = new InsertionSort<int>(unsorted);
            int[] actual = insertionSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void InsertionSort_Sort_SortedDescReturnsSortedArray()
        {
            //Arrange
            int[] unsorted = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            //Act
            ISortable<int> insertionSort = new InsertionSort<int>(unsorted);
            int[] actual = insertionSort.Sort();

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
