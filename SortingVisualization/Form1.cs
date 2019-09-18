using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SortingVisualization
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbkeSort_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            bubble.Sort();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAdd.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
                panelItems.Controls.Add(item.ProgressBar);
                panelItems.Controls.Add(item.Label);
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
                    panelItems.Controls.Add(item.ProgressBar);
                    panelItems.Controls.Add(item.Label);
                }
            }

            txtFill.Text = string.Empty;
        }
    }
}
