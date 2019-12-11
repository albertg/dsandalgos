using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// The worst case time complexity of this algorithm is O(N^2), but as this is randomized algorithm, 
    /// its time complexity fluctuates between O(N^2) and O(N log N) and mostly it comes out to be O(N log N)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSort<T> : ISortable<T> where T : IComparable
    {
        private T[] elements;

        public QuickSort(T[] unsortedArray)
        {
            this.elements = unsortedArray;
        }

        public T[] Sort()
        {
            Sort(elements, 0, elements.Length - 1);
            return elements;
        }

        private void Sort(T[] list, int first, int last)
        {
            //Algorithm used from:
            //https://www.hackerearth.com/practice/algorithms/sorting/quick-sort/tutorial/
            if(first < last)
            {
                int partitionIndex = Partition(list, first, last);
                Sort(list, first, partitionIndex - 1);
                Sort(list, partitionIndex + 1, last);
            }            
        }

        private int Partition(T[] list, int first, int last)
        {
            T pivot = list[first];
            int pivotBoundary = first + 1;//the boundary between the elements that are less than the pivot and those greater then the pivot 
            for(int i = pivotBoundary; i <= last; i++)
            {
                if(list[i].CompareTo(pivot) < 0)//element is less than the pivot
                {         
                    if(i != pivotBoundary)
                    {
                        Swap(list, pivotBoundary, i);
                    }                    
                    pivotBoundary++;
                }
            }
            Swap(list, first, pivotBoundary - 1);
            return pivotBoundary - 1;
        }

        private void Swap(T[] list, int positionA, int positionB)
        {
            T temp = list[positionA];
            list[positionA] = list[positionB];
            list[positionB] = temp;
        }
    }
}
