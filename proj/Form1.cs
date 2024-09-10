using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop(); // Stop the timer
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
