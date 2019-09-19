﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            for (int i = 0; i < 10000; i++)
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

        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(items);

            // act
            shell.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(items);

            // act
            bases.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bases.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            // arrange
            var tree = new TreeSort<int>();
            tree.Items.AddRange(items);

            // act
            tree.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], tree.Items[i]);
            }
        }
    }
}