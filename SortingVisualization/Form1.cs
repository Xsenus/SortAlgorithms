using System;
using System.Collections.Generic;
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

        private void BtnStart_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtAdd.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);
                panel1.Controls.Add(item.ProgressBar);
                panel1.Controls.Add(item.Label);
            }

            txtAdd.Text = string.Empty;
        }

        private void BtnFill_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtFill.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next());
                    items.Add(item);
                    panel1.Controls.Add(item.ProgressBar);
                    panel1.Controls.Add(item.Label);
                }
            }

            txtFill.Text = string.Empty;
        }
    }
}
