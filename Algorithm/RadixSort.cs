using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixSort() { }

        public RadixSort(IEnumerable<T> items) : base(items) { }
        
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            var lenght = GetMaxLenght();

            for (int step = 0; step < lenght; step++)
            {
                // Распределение элементов по корзинам.
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                // Выполняется сборка элементов.
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                // Очистка корзины.
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLenght()
        {
            var lenght = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только целые числа (больше или равные нулю", nameof(Items));
                }

                /*
                 * Не работает со значением Item = 0. Дается -inf.
                 * var l = Convert.ToInt32(Math.Log10(item.GetHashCode() + 1));
                 */

                var l = GetHashCode().ToString().Length;

                if (l > lenght)
                {
                    lenght = l;
                }
            }
            return lenght;
        }
    }
}
