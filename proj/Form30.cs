using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proj
{

    
    public partial class Form30 : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public Form30()
        {
            InitializeComponent();
            InitializePrintComponents();


        }
        private void InitializePrintComponents()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font footerFont = new Font("Arial", 10, FontStyle.Italic);


            float headerHeight = e.Graphics.MeasureString("Header Text", headerFont).Height + 10;
            float footerHeight = e.Graphics.MeasureString("Footer Text", footerFont).Height + 10;


            string headerText = "                                          KEYSTONE PROPERTIES                         ";
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - headerHeight);


            string footerText = $"sasas {DateTime.Now.ToString()}";
            e.Graphics.DrawString(footerText, footerFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + footerHeight / 2);


            Rectangle adjustedBounds = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + (int)headerHeight, e.MarginBounds.Width, e.MarginBounds.Height - (int)headerHeight - (int)footerHeight);


            Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, adjustedBounds);
        }
        public void PrintDataGridView()
        {
            printPreviewDialog.ShowDialog();
        }

        public void AddRow(DataGridViewRow row)
        {
            if (dataGridView1.ColumnCount == 0)
            {
                foreach (DataGridViewColumn column in row.DataGridView.Columns)
                {
                    if (column.Name != "SELECT")
                    {
                        dataGridView1.Columns.Add((DataGridViewColumn)column.Clone());

                    }
                }
            }
            int rowIndex = dataGridView1.Rows.Add();
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.DataGridView.Columns[i].Name != "SELECT")
                {
                    dataGridView1.Rows[rowIndex].Cells[row.DataGridView.Columns[i].Name].Value = row.Cells[i].Value;
                }

            }
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PrintDataGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.name = textBox1.Text;
            UserSession.cont = textBox2.Text;
            UserSession.protype=textBox3.Text;
            UserSession.info=textBox4.Text;
            UserSession.cost=textBox5.Text;
            Form31 f = new Form31();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public static class UserSession
    {
        public static string name = "";
        public static string cont = "";
        public static string protype = "";
        public static string info = "";
        public static string cost = "";
    }
}
