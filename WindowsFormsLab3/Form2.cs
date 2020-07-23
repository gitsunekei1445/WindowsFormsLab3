using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double time=0,ans=0,a=0,b=0,c=0;
            time = Convert.ToDouble(hr.Text);
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);
            if (sad.Checked)
            {
                if(time <= b)
                {
                    ans = a;
                }
                else
                {
                    ans = a + ((time - b) * c);
                }
            }
            else if (bad.Checked)
            {
                if(time <= b)
                {
                    ans = a;
                }
                else
                {
                    ans = a + ((time - b) * c);
                }
            }
            else
            {
                ans = 0;
            }    
            
            pice.Text = Convert.ToString(ans);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sad.Checked)
            {
                textBoxA.Text = "1200";
                textBoxB.Text = "600";
                textBoxC.Text = "2";
            }
            else if (bad.Checked)
            {
                textBoxA.Text = "500";
                textBoxB.Text = "250";
                textBoxC.Text = "5";
            }
            else
            {
                DialogResult Ans = MessageBox.Show("กรุณาเลือกโปรโมชั่น", "เเจ้งเตือน", MessageBoxButtons.OK);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
    }
}
