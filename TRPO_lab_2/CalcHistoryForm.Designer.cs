
namespace TRPO_lab_2
{
    partial class CalcHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClear = new System.Windows.Forms.Button();
            this.historyList = new System.Windows.Forms.DataGridView();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(232, 377);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // historyList
            // 
            this.historyList.AllowUserToAddRows = false;
            this.historyList.AllowUserToDeleteRows = false;
            this.historyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResult});
            this.historyList.Location = new System.Drawing.Point(12, 12);
            this.historyList.Name = "historyList";
            this.historyList.ReadOnly = true;
            this.historyList.RowHeadersVisible = false;
            this.historyList.Size = new System.Drawing.Size(492, 359);
            this.historyList.TabIndex = 3;
            this.historyList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyList_CellDoubleClick);
            // 
            // ColumnResult
            // 
            this.ColumnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnResult.HeaderText = "Результат";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CalcHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 410);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.historyList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalcHistoryForm";
            this.Text = "История";
            ((System.ComponentModel.ISupportInitialize)(this.historyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView historyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
    }
}