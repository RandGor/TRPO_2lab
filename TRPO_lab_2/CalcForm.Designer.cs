
namespace TRPO_lab_2
{
    partial class CalcForm
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
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMP = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.labelMemUsed = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelAcuracy = new System.Windows.Forms.Label();
            this.конвертерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonClear.Location = new System.Drawing.Point(328, 64);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 53;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxFrom.Location = new System.Drawing.Point(12, 38);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(446, 20);
            this.textBoxFrom.TabIndex = 49;
            // 
            // numericFrom
            // 
            this.numericFrom.Location = new System.Drawing.Point(409, 64);
            this.numericFrom.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericFrom.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(49, 20);
            this.numericFrom.TabIndex = 47;
            this.numericFrom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericFrom.ValueChanged += new System.EventHandler(this.numericFrom_ValueChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(290, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 20);
            this.buttonBack.TabIndex = 46;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.Color.Crimson;
            this.button15.Location = new System.Drawing.Point(290, 135);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 20);
            this.button15.TabIndex = 45;
            this.button15.Text = "F";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.ForeColor = System.Drawing.Color.Crimson;
            this.button14.Location = new System.Drawing.Point(197, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 20);
            this.button14.TabIndex = 44;
            this.button14.Text = "E";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.Crimson;
            this.button13.Location = new System.Drawing.Point(104, 135);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 20);
            this.button13.TabIndex = 43;
            this.button13.Text = "D";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.Color.Crimson;
            this.button12.Location = new System.Drawing.Point(290, 176);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 20);
            this.button12.TabIndex = 42;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Crimson;
            this.button11.Location = new System.Drawing.Point(197, 176);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 20);
            this.button11.TabIndex = 41;
            this.button11.Text = "B";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Crimson;
            this.button10.Location = new System.Drawing.Point(104, 176);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 20);
            this.button10.TabIndex = 40;
            this.button10.Text = "A";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(197, 340);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 20);
            this.buttonDot.TabIndex = 39;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(290, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 20);
            this.button9.TabIndex = 38;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(105, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 20);
            this.button7.TabIndex = 36;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(290, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 20);
            this.button6.TabIndex = 35;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 34;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 33;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 32;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 31;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(104, 340);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 20);
            this.button0.TabIndex = 29;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonMC
            // 
            this.buttonMC.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMC.Location = new System.Drawing.Point(12, 135);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(75, 20);
            this.buttonMC.TabIndex = 52;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMR.Location = new System.Drawing.Point(12, 176);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(75, 20);
            this.buttonMR.TabIndex = 52;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMS.Location = new System.Drawing.Point(12, 217);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(75, 20);
            this.buttonMS.TabIndex = 52;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMP
            // 
            this.buttonMP.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMP.Location = new System.Drawing.Point(12, 258);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(75, 20);
            this.buttonMP.TabIndex = 52;
            this.buttonMP.Text = "M+";
            this.buttonMP.UseVisualStyleBackColor = true;
            this.buttonMP.Click += new System.EventHandler(this.buttonMP_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(197, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 20);
            this.button8.TabIndex = 37;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button21.Location = new System.Drawing.Point(383, 135);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 20);
            this.button21.TabIndex = 38;
            this.button21.Text = "/";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button20.Location = new System.Drawing.Point(383, 176);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 20);
            this.button20.TabIndex = 38;
            this.button20.Text = "X";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button22.Location = new System.Drawing.Point(383, 217);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 20);
            this.button22.TabIndex = 38;
            this.button22.Text = "—";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button23.Location = new System.Drawing.Point(383, 258);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 20);
            this.button23.TabIndex = 38;
            this.button23.Text = "+";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button24.Location = new System.Drawing.Point(383, 299);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 20);
            this.button24.TabIndex = 38;
            this.button24.Text = "1/x";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button25.Location = new System.Drawing.Point(383, 340);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 20);
            this.button25.TabIndex = 38;
            this.button25.Text = "x^2";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // labelMemUsed
            // 
            this.labelMemUsed.AutoSize = true;
            this.labelMemUsed.ForeColor = System.Drawing.Color.Tomato;
            this.labelMemUsed.Location = new System.Drawing.Point(442, 22);
            this.labelMemUsed.Name = "labelMemUsed";
            this.labelMemUsed.Size = new System.Drawing.Size(16, 13);
            this.labelMemUsed.TabIndex = 55;
            this.labelMemUsed.Text = "M";
            this.labelMemUsed.Visible = false;
            // 
            // buttonCompute
            // 
            this.buttonCompute.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonCompute.Location = new System.Drawing.Point(197, 90);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(75, 20);
            this.buttonCompute.TabIndex = 52;
            this.buttonCompute.Text = "=";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.конвертерToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 64);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 57;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelAcuracy
            // 
            this.labelAcuracy.AutoSize = true;
            this.labelAcuracy.Location = new System.Drawing.Point(12, 97);
            this.labelAcuracy.Name = "labelAcuracy";
            this.labelAcuracy.Size = new System.Drawing.Size(66, 13);
            this.labelAcuracy.TabIndex = 58;
            this.labelAcuracy.Text = "Точность: 0";
            // 
            // конвертерToolStripMenuItem
            // 
            this.конвертерToolStripMenuItem.Name = "конвертерToolStripMenuItem";
            this.конвертерToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.конвертерToolStripMenuItem.Text = "Конвертер";
            this.конвертерToolStripMenuItem.Click += new System.EventHandler(this.конвертерToolStripMenuItem_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 371);
            this.Controls.Add(this.labelAcuracy);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelMemUsed);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.buttonMP);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.numericFrom);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.NumericUpDown numericFrom;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label labelMemUsed;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelAcuracy;
        private System.Windows.Forms.ToolStripMenuItem конвертерToolStripMenuItem;
    }
}