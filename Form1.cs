using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int n, m, i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Номер накладной");
            dataGridView1.Columns.Add("Fa", "Поставщик");
            dataGridView1.Columns.Add("Name", "Заказ");
            dataGridView1.Columns.Add("DT", "Сумма");
            dataGridView1.Columns.Add("KL", "Количество");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[rowNumber].Cells[3].Value = textBox3.Text;
            dataGridView1.Rows[rowNumber].Cells[4].Value = textBox4.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 Выход = new Form2();
            Выход.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount;
            m = dataGridView1.ColumnCount;
            StreamWriter sw = File.CreateText("data.txt");
            sw.WriteLine(Convert.ToString(n));
            sw.WriteLine(Convert.ToString(m));
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sw.WriteLine(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("data.txt");
            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());
            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
                dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[rowNumber].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[rowNumber].Cells[4].Value = textBox4.Text;
            }
            f.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 Сотрудники = new Form3();
            Сотрудники.ShowDialog();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
