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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select count(*) from buyreg where User_Id=@User_Id AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@User_Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login successfully Successfully.... :)", "SIGN-IN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form25 f = new Form25();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials ","SIGN-IN",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
