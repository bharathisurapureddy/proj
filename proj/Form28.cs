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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            LoadData();
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\keert\\OneDrive\\Documents\\re.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from medgold", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            MessageBox.Show("Moving to Available gold data ...", "CONFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "BUY";
            checkBoxColumn.Name = "SELECT";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form30 form30 = new Form30();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["SELECT"];
                if (checkBox.Value != null && (bool)checkBox.Value)
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.DataGridView.Columns[i].Name != "SELECT")
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                    }


                    form30.AddRow(row);

                }
            }

            form30.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form25 f = new Form25();
            f.Show();
        }
    }
}
