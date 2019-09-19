using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public int Count => Items.Count;

        public HeapSort(IEnumerable<T> items)
        {
            Items.AddRange(items);

            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        private void Sort(int currentIndex, int maxLenght = -1)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            maxLenght = maxLenght == -1 ? Count : maxLenght;

            while (currentIndex < maxLenght)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < maxLenght && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < maxLenght && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swop(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        protected override void MakeSort()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Sort(0, i);
            }
        }
    }
}
