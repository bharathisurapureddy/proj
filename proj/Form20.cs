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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 f = new Form21();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 f = new Form22();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 f = new Form23();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 f = new Form24();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
