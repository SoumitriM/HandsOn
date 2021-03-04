using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void input1_TextChanged(object sender, EventArgs e)
        {

        }
        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnSubtract_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnDivide_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            double a, b;
            double c=0;
            a = Convert.ToDouble(input1.Text);
            b = Convert.ToDouble(input2.Text);
            if (btnAdd.Checked) c = a + b;
            if (btnSubtract.Checked) c = a - b;
            if (btnMultiply.Checked) c = a * b;
            if (btnDivide.Checked) c = a/b;
            string res = c.ToString();
            MessageBox.Show(res);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
