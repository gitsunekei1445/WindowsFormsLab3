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
    public partial class Form1 : Form
    {
        int Lx, Ly;
        Random Ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Lx += 1;
            if (Lx%500 == 0)
            {
                Lx = Ran.Next(10, 500);
                Ly = Ran.Next(10, 500);
            }
            pictureBox1.Location = new Point(Lx, Ly);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณต้องการเข้าโปรเเกรมหรือไหม");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Lx = Ran.Next(10, 500);
            Ly = Ran.Next(10, 500);
            timer1.Interval = 10;
            timer1.Enabled = true;

        }
    }
}
