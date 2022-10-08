using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AreaCompute
{
    public partial class FormRectangle : Form
    {
        public FormRectangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelect f = new FormSelect();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                double S = a * b;
                double P = a + b;

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Invalid value - Please enter valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show($"Area: {S}\nPerimeter: {P}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
                {
                    MessageBox.Show("Fill all numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Input numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
