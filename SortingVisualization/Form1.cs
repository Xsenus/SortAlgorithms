using Algorithm;
using System.Windows.Forms;

namespace SortingVisualization
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            algorithm.Sort();

            foreach (var item in algorithm.Items)
            {
                lblOut.Text += $" {item}";
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtBox.Text, out int value))
            {
                algorithm.Items.Add(value);
                lblIn.Text += $" {value}";
            }
        }
    }
}
