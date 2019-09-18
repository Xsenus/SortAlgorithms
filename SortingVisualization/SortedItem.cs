using System.Windows.Forms;

namespace SortingVisualization
{
    class SortedItem
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }

        public Label Label { get; private set; }

        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;

            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            // 
            // verticalProgressBar
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(12, 14);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size(16, 88);
            ProgressBar.Step = 10;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = 0;
            ProgressBar.Value = Value;
            // 
            // lbl
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(15, 105);
            Label.Name = "lbl";
            Label.Size = new System.Drawing.Size(13, 13);
            Label.TabIndex = 10;
            Label.Text = Value.ToString(); ;
        }
    }
}
