using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proj
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Selreg values(@User_Id,@Password)", conn);
            cmd.Parameters.AddWithValue("@User_Id", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox6.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registered Sucessfully.... :)","REGISTERED",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
