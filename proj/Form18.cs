using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f = new Form15();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into selgold values(@Name,@Contact,@Weight,@Carats,@Cost)", conn);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Weight", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Carats", textBox4.Text);
            cmd.Parameters.AddWithValue("@Cost", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Gold Details Saved Successfully .... :)", "CONFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f = new Form2();
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
