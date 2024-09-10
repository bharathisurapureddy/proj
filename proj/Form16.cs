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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f = new Form15();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into selland values(@Name,@Contact,@Area,@Address,@Cost)", conn);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Area", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.Parameters.AddWithValue("@Cost", int.Parse(textBox5.Text));
           

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Land Details Saved Successfully .... :)","CONFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Form2 f = new Form2();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
