using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    { 

        public Calculator()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 0;
        }

        private void zeroZeroBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 0 + 0;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 1;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 2;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 3;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 4;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 5;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 6;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 7;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 8;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + 9;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 2;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                num1 = float.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 1;
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 3;
        }

        private void devideBtn_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 4;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            int c = txtBox.TextLength;
            int flag = 0;
            string text = txtBox.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtBox.Text = txtBox.Text + ".";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            count = 0;
        }
    }
}
