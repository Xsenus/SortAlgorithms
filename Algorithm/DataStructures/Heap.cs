using System;
using System.Collections.Generic;

namespace Algorithm.DataStructures
{
    class Heap<T> where T : IComparable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public Heap() { }

        public Heap(IEnumerable<T> items)
        {
            this.items.AddRange(items);

            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        /// <summary>
        /// Возвращение максимального элемента из двоичной кучи без извлечения.
        /// </summary>
        /// <returns>Максимальный элемент.</returns>
        public T Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                throw new ArgumentNullException(nameof(items), "Куча пуста");
            }
        }

        /// <summary>
        /// Добавление нового элемента в двоичную кучу.
        /// </summary>
        public void Add(T item)
        {
            items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        /// <summary>
        /// Возвращение максимального элемента из двоичной кучи c перестроением.
        /// </summary>
        public T GetMax()
        {
            var retuls = items[0];

            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);

            return retuls;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private static int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public List<T> Order()
        {
            var result = new List<T>();

            while (Count > 0)
            {
                result.Add(GetMax());
            }

            return result;
        }
    }
}
