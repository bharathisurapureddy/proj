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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSessiona.kname = textBox1.Text;
            UserSessiona.kcont=textBox2.Text;
            Form32 form32 = new Form32();   
            form32.ShowDialog();    
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }
    }
    public static class UserSessiona
        {
        public static string kname;
        public static string kcont;
    }
}
