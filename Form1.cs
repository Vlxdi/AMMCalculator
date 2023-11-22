using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AMMCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string inputText = txtBox1.Text;
            List<int> numbers = new List<int>();

            foreach (var numText in inputText.Split(' '))
            {
                // Skip empty strings
                if (string.IsNullOrWhiteSpace(numText))
                {
                    continue;
                }

                if (int.TryParse(numText, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    MessageBox.Show("Error: Not a valid input. Please enter numbers.");
                    txtBox1.Clear();
                    return;
                }
            }

            double average = numbers.Count > 0 ? numbers.Average() : 0;
            lblAverage.Text = $"Average: {average:F2}";

            List<int> modes = CalculateMode(numbers);
            if (modes.Count > 0)
            {
                lblMode.Text = $"Mode: {string.Join(", ", modes)}";
            }
            else
            {
                lblMode.Text = "Mode: No mode available for these numbers";
            }

            double median = CalculateMedian(numbers);
            DisplayMedianChart(median);


            txtBox1.Clear();
        }

        private List<int> CalculateMode(List<int> numbers)
        {
            var groupedNumbers = numbers.GroupBy(n => n);
            var maxFrequency = groupedNumbers.Max(g => g.Count());

            if (maxFrequency <= 1)
            {
                return new List<int>();
            }

            return groupedNumbers.Where(g => g.Count() == maxFrequency)
                                .Select(g => g.Key)
                                .ToList();
        }

        private double CalculateMedian(List<int> numbers)
        {
            numbers.Sort();

            int count = numbers.Count;
            double median;

            if (count % 2 == 0)
            {
                median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
            }
            else
            {
                median = numbers[count / 2];
            }

            return median;
        }

        private void DisplayMedianChart(double median)
        {
            chartMedian.Series.Clear();
            
            Series medianSeries = new Series("Median");
            medianSeries.Points.AddY(median);

            chartMedian.Series.Add(medianSeries);
        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
                btn1_Click(sender, e);
                e.Handled = true;
            }
        }


        //empty
        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void lblMode_Click(object sender, EventArgs e)
        {

        }

        private void chartMedian_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
