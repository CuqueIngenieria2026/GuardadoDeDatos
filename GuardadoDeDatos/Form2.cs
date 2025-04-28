using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardadoDeDatos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text
                , textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.BeginEdit(true);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
    }
}
