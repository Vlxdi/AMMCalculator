namespace AMMCalculator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblResultsText = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.chartMedian = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNumbersText = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedian)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox1.Location = new System.Drawing.Point(266, 47);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(217, 29);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(502, 45);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 32);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Submit";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblResultsText
            // 
            this.lblResultsText.AutoSize = true;
            this.lblResultsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultsText.Location = new System.Drawing.Point(355, 106);
            this.lblResultsText.Name = "lblResultsText";
            this.lblResultsText.Size = new System.Drawing.Size(75, 20);
            this.lblResultsText.TabIndex = 2;
            this.lblResultsText.Text = "Results:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverage.Location = new System.Drawing.Point(263, 138);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(62, 15);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMode.Location = new System.Drawing.Point(263, 174);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(47, 15);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Mode:";
            this.lblMode.Click += new System.EventHandler(this.lblMode_Click);
            // 
            // chartMedian
            // 
            this.chartMedian.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.chartMedian.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartMedian.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartMedian.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMedian.Legends.Add(legend1);
            this.chartMedian.Location = new System.Drawing.Point(348, 212);
            this.chartMedian.Name = "chartMedian";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMedian.Series.Add(series1);
            this.chartMedian.Size = new System.Drawing.Size(229, 226);
            this.chartMedian.TabIndex = 5;
            this.chartMedian.Text = "Median";
            this.chartMedian.Click += new System.EventHandler(this.chartMedian_Click);
            // 
            // lblNumbersText
            // 
            this.lblNumbersText.AutoSize = true;
            this.lblNumbersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbersText.Location = new System.Drawing.Point(323, 18);
            this.lblNumbersText.Name = "lblNumbersText";
            this.lblNumbersText.Size = new System.Drawing.Size(93, 15);
            this.lblNumbersText.TabIndex = 6;
            this.lblNumbersText.Text = "Enter Numbers:";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedian.Location = new System.Drawing.Point(263, 212);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(59, 15);
            this.lblMedian.TabIndex = 7;
            this.lblMedian.Text = "Median:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedian);
            this.Controls.Add(this.lblNumbersText);
            this.Controls.Add(this.chartMedian);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblResultsText);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMedian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblResultsText;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedian;
        private System.Windows.Forms.Label lblNumbersText;
        private System.Windows.Forms.Label lblMedian;
    }
}

