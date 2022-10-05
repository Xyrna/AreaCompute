using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.MonthCalendar;

namespace AreaCompute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Set the value to the side!", "Unassigned Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        

            else
            {
                char f = '0';
                foreach (char c in textBox1.Text)
                {
                    if (c < '0' || c > '9')
                        f = 'f';
                    else
                        f = 't';
                }

                
                if (f == 't')
                {
                    double a = Convert.ToDouble(textBox1.Text);

                    if (a <= 0)
                    {
                        MessageBox.Show("Invalid value - Please enter valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        double s = Math.Pow(a, 2);
                        double v = Math.Pow(a, 3);
                        MessageBox.Show("S = " + s + "\n" + "V = " + v);
                    }
                }
                else if (f == 'f')
                { MessageBox.Show("The value must contain only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
