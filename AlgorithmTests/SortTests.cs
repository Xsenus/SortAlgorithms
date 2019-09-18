using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> items = new List<int>();
        List<int> sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            items.Clear();

            for (int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // arrange
            var buble = new BubbleSort<int>();
            buble.Items.AddRange(items);

            // act
            buble.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], buble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(items);

            // act
            cocktail.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], cocktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(items);

            // act
            insert.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }
    }
}