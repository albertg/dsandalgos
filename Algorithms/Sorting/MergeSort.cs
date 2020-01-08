using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSort<T> : ISortable<T> where T : IComparable
    {
        private T[] elements;

        public MergeSort(T[] unsortedArray)
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
            if(first < last)
            {
                int middle = (last + first) / 2;
                Sort(list, first, middle);
                Sort(list, middle + 1, last);

                Merge(list, first, middle, last);
            }
        }

        private void Merge(T[] list, int first, int middle, int last)
        {
            int sizeOfListOne = middle - first + 1;
            int sizeOfListTwo = last - middle;

            T[] left = new T[sizeOfListOne];
            T[] right = new T[sizeOfListTwo];

            for(int i = 0; i < sizeOfListOne; i++)
            {
                left[i] = list[first + i];
            }
            for(int j = 0; j < sizeOfListTwo; j++)
            {
                right[j] = list[middle + 1 + j];
            }

            int listOneIndex = 0, listTwoIndex = 0, mergedListIndex = first;

            while(listOneIndex < sizeOfListOne && listTwoIndex < sizeOfListTwo)
            {
                if(left[listOneIndex].CompareTo(right[listTwoIndex]) <= 0)
                {
                    list[mergedListIndex] = left[listOneIndex];
                    listOneIndex++;
                }
                else
                {
                    list[mergedListIndex] = right[listTwoIndex];
                    listTwoIndex++;
                }
                mergedListIndex++;
            }

            while(listOneIndex < sizeOfListOne)
            {
                list[mergedListIndex] = left[listOneIndex];
                listOneIndex++;
                mergedListIndex++;
            }
            while(listTwoIndex < sizeOfListTwo)
            {
                list[mergedListIndex] = right[listTwoIndex];
                listTwoIndex++;
                mergedListIndex++;
            }
        }
    }
}
