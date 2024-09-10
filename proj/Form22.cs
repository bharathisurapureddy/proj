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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from selhouse", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            MessageBox.Show("Moving to Available Houses data ...", "CONFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into medhouse values(@Name,@Contact,@House_Type,@Area,@Address,@Cost)", conn);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@House_Type", textBox3.Text);
            cmd.Parameters.AddWithValue("@Area", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Cost", int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Commission Added Successfully .... :)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox6.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 f = new Form20();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
