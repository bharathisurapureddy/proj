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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form32_Load(object sender, EventArgs e)
        {
            label1.Text = $"Seller Name           :        {UserSession.name}";
            label2.Text = $"Seller Contact        :        {UserSession.cont}";
            label3.Text = $"Property info         :        {UserSession.protype}";
            label4.Text = $"Extra Property info   :        {UserSession.info}";
            label5.Text = $"Cost                  :        {UserSession.cost}";
            label6.Text = $"Name                  :        {UserSessiona.kname}";
            label7.Text = $"Contact               :        {UserSessiona.kcont}";

            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.ShowDialog();
            Form32 f = new Form32();
            f.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    
    }
