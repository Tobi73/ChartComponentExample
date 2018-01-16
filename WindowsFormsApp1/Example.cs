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

namespace WindowsFormsApp1
{
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customGroupBox1.testAddData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customGroupBox1.ConvertToExcel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customGroupBox1.SerializeJson();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customGroupBox1.DeserializeJson();
            customGroupBox1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customGroupBox1.TypeOfChart = (SeriesChartType)comboBox1.SelectedItem;
            customGroupBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var a in Enum.GetValues(typeof(SeriesChartType)))
            {
                comboBox1.Items.Add(a);
            }
        }
    }
}
