using Algorithm.DataStructures;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable 
    {
        public TreeSort() { }

        public TreeSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
