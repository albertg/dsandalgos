using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BubbleSort<T> : ISortable<T> where T : IComparable
    {
        private T[] elements;

        public BubbleSort(T[] unsortedArray)
        {
            elements = unsortedArray;
        }

        public T[] Sort()
        {
            int length = elements.Length;
            for(int i = 0; i < length; i++)
            {
                for (int j = 0; j < length-i-1; j++)
                {
                    if(elements[j].CompareTo(elements[j + 1]) > 0)
                    {
                        Swap(j, j + 1);
                    }
                }
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
