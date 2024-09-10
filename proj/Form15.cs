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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 form17 = new Form17();
            form17.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 form18 = new Form18();
            form18.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
