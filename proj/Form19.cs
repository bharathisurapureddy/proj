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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
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
            SqlCommand cmd = new SqlCommand("insert into selvehicle values(@Name,@Contact,@Vehicle_Type,@Mileage,@Cost)", conn);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Vehicle_Type", textBox3.Text);
            cmd.Parameters.AddWithValue("@Mileage", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Cost", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Vehicle Details Saved Successfully .... :)", "CONFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f = new Form2();
            f.Show();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }
    }
}
