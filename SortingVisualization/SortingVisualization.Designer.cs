namespace SortingVisualization
{
    partial class SortingVisualization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingVisualization));
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.lblFill = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblComparison = new System.Windows.Forms.Label();
            this.lblSwop = new System.Windows.Forms.Label();
            this.btnCocktailSort = new System.Windows.Forms.Button();
            this.btnInsertSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnTreeSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnGnomeSort = new System.Windows.Forms.Button();
            this.btnLSDRadixSort = new System.Windows.Forms.Button();
            this.btnMSDRadixSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.txtFill = new System.Windows.Forms.TextBox();
            this.panelAdd.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBubbleSort
            // 
            resources.ApplyResources(this.btnBubbleSort, "btnBubbleSort");
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.BtnBubbleSort_Click);
            // 
            // txtAdd
            // 
            resources.ApplyResources(this.txtAdd, "txtAdd");
            this.txtAdd.Name = "txtAdd";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblAdd);
            this.panelAdd.Controls.Add(this.txtAdd);
            this.panelAdd.Controls.Add(this.btnAdd);
            resources.ApplyResources(this.panelAdd, "panelAdd");
            this.panelAdd.Name = "panelAdd";
            // 
            // lblAdd
            // 
            resources.ApplyResources(this.lblAdd, "lblAdd");
            this.lblAdd.Name = "lblAdd";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.txtFill);
            this.panelFill.Controls.Add(this.lblFill);
            this.panelFill.Controls.Add(this.btnFill);
            resources.ApplyResources(this.panelFill, "panelFill");
            this.panelFill.Name = "panelFill";
            // 
            // lblFill
            // 
            resources.ApplyResources(this.lblFill, "lblFill");
            this.lblFill.Name = "lblFill";
            // 
            // btnFill
            // 
            resources.ApplyResources(this.btnFill, "btnFill");
            this.btnFill.Name = "btnFill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // panelItems
            // 
            resources.ApplyResources(this.panelItems, "panelItems");
            this.panelItems.Name = "panelItems";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // lblComparison
            // 
            resources.ApplyResources(this.lblComparison, "lblComparison");
            this.lblComparison.Name = "lblComparison";
            // 
            // lblSwop
            // 
            resources.ApplyResources(this.lblSwop, "lblSwop");
            this.lblSwop.Name = "lblSwop";
            // 
            // btnCocktailSort
            // 
            resources.ApplyResources(this.btnCocktailSort, "btnCocktailSort");
            this.btnCocktailSort.Name = "btnCocktailSort";
            this.btnCocktailSort.UseVisualStyleBackColor = true;
            this.btnCocktailSort.Click += new System.EventHandler(this.BtnCocktailSort_Click);
            // 
            // btnInsertSort
            // 
            resources.ApplyResources(this.btnInsertSort, "btnInsertSort");
            this.btnInsertSort.Name = "btnInsertSort";
            this.btnInsertSort.UseVisualStyleBackColor = true;
            this.btnInsertSort.Click += new System.EventHandler(this.BtnInsertSort_Click);
            // 
            // btnShellSort
            // 
            resources.ApplyResources(this.btnShellSort, "btnShellSort");
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.BtnShellSort_Click);
            // 
            // btnTreeSort
            // 
            resources.ApplyResources(this.btnTreeSort, "btnTreeSort");
            this.btnTreeSort.Name = "btnTreeSort";
            this.btnTreeSort.UseVisualStyleBackColor = true;
            this.btnTreeSort.Click += new System.EventHandler(this.BtnTreeSort_Click);
            // 
            // btnHeapSort
            // 
            resources.ApplyResources(this.btnHeapSort, "btnHeapSort");
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.BtnHeapSort_Click);
            // 
            // btnSelectionSort
            // 
            resources.ApplyResources(this.btnSelectionSort, "btnSelectionSort");
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.BtnSelectionSort_Click);
            // 
            // btnGnomeSort
            // 
            resources.ApplyResources(this.btnGnomeSort, "btnGnomeSort");
            this.btnGnomeSort.Name = "btnGnomeSort";
            this.btnGnomeSort.UseVisualStyleBackColor = true;
            this.btnGnomeSort.Click += new System.EventHandler(this.BtnGnomeSort_Click);
            // 
            // btnLSDRadixSort
            // 
            resources.ApplyResources(this.btnLSDRadixSort, "btnLSDRadixSort");
            this.btnLSDRadixSort.Name = "btnLSDRadixSort";
            this.btnLSDRadixSort.UseVisualStyleBackColor = true;
            this.btnLSDRadixSort.Click += new System.EventHandler(this.BtnLSDRadixSort_Click);
            // 
            // btnMSDRadixSort
            // 
            resources.ApplyResources(this.btnMSDRadixSort, "btnMSDRadixSort");
            this.btnMSDRadixSort.Name = "btnMSDRadixSort";
            this.btnMSDRadixSort.UseVisualStyleBackColor = true;
            this.btnMSDRadixSort.Click += new System.EventHandler(this.BtnMSDRadixSort_Click);
            // 
            // btnMergeSort
            // 
            resources.ApplyResources(this.btnMergeSort, "btnMergeSort");
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.BtnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            resources.ApplyResources(this.btnQuickSort, "btnQuickSort");
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.BtnQuickSort_Click);
            // 
            // txtFill
            // 
            resources.ApplyResources(this.txtFill, "txtFill");
            this.txtFill.Name = "txtFill";
            // 
            // SortingVisualization
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnMSDRadixSort);
            this.Controls.Add(this.btnLSDRadixSort);
            this.Controls.Add(this.btnGnomeSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnTreeSort);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnInsertSort);
            this.Controls.Add(this.btnCocktailSort);
            this.Controls.Add(this.lblSwop);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnBubbleSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortingVisualization";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Label lblSwop;
        private System.Windows.Forms.Button btnCocktailSort;
        private System.Windows.Forms.Button btnInsertSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnTreeSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnGnomeSort;
        private System.Windows.Forms.Button btnLSDRadixSort;
        private System.Windows.Forms.Button btnMSDRadixSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.TextBox txtFill;
    }
}

