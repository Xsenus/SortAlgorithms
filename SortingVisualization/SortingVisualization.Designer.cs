﻿namespace SortingVisualization
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
            this.btnBubbkeSort = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.lblFill = new System.Windows.Forms.Label();
            this.txtFill = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblComparison = new System.Windows.Forms.Label();
            this.lblSwop = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBubbkeSort
            // 
            this.btnBubbkeSort.Location = new System.Drawing.Point(12, 138);
            this.btnBubbkeSort.Name = "btnBubbkeSort";
            this.btnBubbkeSort.Size = new System.Drawing.Size(129, 23);
            this.btnBubbkeSort.TabIndex = 1;
            this.btnBubbkeSort.Text = "BubbleSort";
            this.btnBubbkeSort.UseVisualStyleBackColor = true;
            this.btnBubbkeSort.Click += new System.EventHandler(this.btnBubbkeSort_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(6, 19);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(169, 20);
            this.txtAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblAdd);
            this.panelAdd.Controls.Add(this.txtAdd);
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Location = new System.Drawing.Point(12, 12);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(267, 57);
            this.panelAdd.TabIndex = 6;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(3, 3);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(92, 13);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Добавить число:";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.lblFill);
            this.panelFill.Controls.Add(this.txtFill);
            this.panelFill.Controls.Add(this.btnFill);
            this.panelFill.Location = new System.Drawing.Point(12, 75);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(267, 57);
            this.panelFill.TabIndex = 8;
            // 
            // lblFill
            // 
            this.lblFill.AutoSize = true;
            this.lblFill.Location = new System.Drawing.Point(3, 3);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(172, 13);
            this.lblFill.TabIndex = 7;
            this.lblFill.Text = "Заполнить случайными числами";
            // 
            // txtFill
            // 
            this.txtFill.Location = new System.Drawing.Point(6, 19);
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(169, 20);
            this.txtFill.TabIndex = 2;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(181, 19);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 20);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // panelItems
            // 
            this.panelItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItems.Location = new System.Drawing.Point(285, 12);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(387, 120);
            this.panelItems.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(15, 164);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время выполнения:";
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Location = new System.Drawing.Point(15, 177);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(126, 13);
            this.lblComparison.TabIndex = 11;
            this.lblComparison.Text = "Количество сравнений:";
            // 
            // lblSwop
            // 
            this.lblSwop.AutoSize = true;
            this.lblSwop.Location = new System.Drawing.Point(15, 190);
            this.lblSwop.Name = "lblSwop";
            this.lblSwop.Size = new System.Drawing.Size(116, 13);
            this.lblSwop.TabIndex = 12;
            this.lblSwop.Text = "Количество обменов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 217);
            this.Controls.Add(this.lblSwop);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnBubbkeSort);
            this.Name = "Form1";
            this.Text = "Визуализация сортировок";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBubbkeSort;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.TextBox txtFill;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Label lblSwop;
    }
}
