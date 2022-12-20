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
    public partial class Form3 : Form
    {
        int n, m, i, j;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Код_Сотрудника");
            dataGridView1.Columns.Add("Fa", "ФИО");
            dataGridView1.Columns.Add("Name", "Должность");
            dataGridView1.Columns.Add("DT2", "Дата рождения");
            dataGridView1.Columns.Add("DT", "Телефон");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form3 Выход = new Form3();
            Выход.ShowDialog();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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
    }
}
