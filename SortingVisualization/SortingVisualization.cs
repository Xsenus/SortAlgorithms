using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void btnBubbkeSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;

            var time = bubble.Sort();

            lblTime.Text = $"Время выполнения: {time.Milliseconds} мс";
            lblComparison.Text = $"Количество сравнений: {bubble.ComparisonCount}";
            lblSwop.Text = $"Количество обменов: {bubble.SwopCount}";
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panelItems.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
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
