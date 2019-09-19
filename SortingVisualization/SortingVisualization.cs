using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SortingVisualization
{
    public partial class SortingVisualization : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public SortingVisualization()
        {
            InitializeComponent();
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;

            var time = algorithm.Sort();

            lblTime.Text = $"Время выполнения: {time.Milliseconds} мс";
            lblComparison.Text = $"Количество сравнений: {algorithm.ComparisonCount}";
            lblSwop.Text = $"Количество обменов: {algorithm.SwopCount}";
        }

        private void BtnBubbleSort_Click(object sender, EventArgs e)
        {            
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
        }

        private void BtnCocktailSort_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }

        private void BtnInsertSort_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }
        
        private void BtnShellSort_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void BtnTreeSort_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BtnClick(tree);
        }

        private void BtnHeapSort_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);
            BtnClick(heap);
        }

        private void BtnSelectionSort_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnClick(selection);
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void Algorithm_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panelItems.Refresh();
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panelItems.Refresh();

            Thread.Sleep(100);
            
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panelItems.Refresh();
        }

        private void DrawItems(List<SortedItem> items)
        {
            panelItems.Controls.Clear();

            foreach (var item in items)
            {
                panelItems.Controls.Add(item.ProgressBar);
                panelItems.Controls.Add(item.Label);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAdd.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
                RefreshItems();
            }

            txtAdd.Text = string.Empty;
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFill.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(0, 100), items.Count);
                    items.Add(item);
                }
            }

            RefreshItems();

            txtFill.Text = string.Empty;
        }
    }
}
