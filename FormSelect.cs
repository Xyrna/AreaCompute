using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCompute
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTriangle f = new FormTriangle();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRectangle f = new FormRectangle();
            f.Show();
            Hide();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
