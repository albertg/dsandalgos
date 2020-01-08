using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting 
{
    public class InsertionSort<T> : ISortable<T> where T : IComparable 
    {
        private T[] elements;

        public InsertionSort(T[] unsortedArray) {
            this.elements = unsortedArray;
        }

        public T[] Sort() 
        {//12, 11, 13, 5, 6
            int length = elements.Length;
            for(int i = 1; i < length; i++)
            {
                T key = elements[i];
                int j = i - 1;

                while(j >= 0 && elements[j].CompareTo(key) > 0)
                {
                    elements[j + 1] = elements[j];
                    j = j - 1;
                }
                elements[j + 1] = key;
            }

            return elements;
        }
    }
}
