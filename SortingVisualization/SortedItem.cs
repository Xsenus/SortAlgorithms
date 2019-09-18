using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualization
{
    class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }

        public Label Label { get; private set; }

        public int Value { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var x = number * 20;

            // 
            // verticalProgressBar
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 14);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = $"ProgressBar{number}";
            ProgressBar.Size = new System.Drawing.Size(16, 88);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // lbl
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, 105);
            Label.Name = $"lbl{number}";
            Label.Size = new System.Drawing.Size(13, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetNewValue(int value)
        {
            Value = value;
            ProgressBar.Value = value;
            Label.Text = value.ToString();
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
    }
}
