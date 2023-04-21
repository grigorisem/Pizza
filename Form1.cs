using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            int max_j = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    if (int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()) > max)
                    {
                        max = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        max_j = j;
                    }
                }
                double mid = (double)sum / dataGridView1.Rows[i].Cells.Count;
                MessageBox.Show("Среднее кол-во заказов: " + mid.ToString() + " ");
                MessageBox.Show("Максимальное кол-во заказов за день: " + max.ToString());
                MessageBox.Show("День: " + (max_j + 1));

            }

        }
    }
}
