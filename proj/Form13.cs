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

namespace proj
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into buyreg values(@User_Id,@Password)", conn);
            cmd.Parameters.AddWithValue("@User_Id", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox6.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registered Successfully.... :)", "REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
