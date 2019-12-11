using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort<T> : ISortable<T> where T : IComparable
    {
        private T[] elements;

        public SelectionSort(T[] unsortedArray)
        {
            this.elements = unsortedArray;
        }

        public T[] Sort()
        {
            int length = elements.Length;
            for(int i = 0; i < length - 1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < length; j++)
                {
                    if(elements[minIndex].CompareTo(elements[j]) > 0)
                    {
                        minIndex = j;
                    }
                }

                Swap(i, minIndex);
            }

            return elements;
        }

        private void Swap(int positionA, int positionB)
        {
            T temp = elements[positionA];
            elements[positionA] = elements[positionB];
            elements[positionB] = temp;
        }
    }
}
