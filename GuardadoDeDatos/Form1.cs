namespace GuardadoDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Cuque")
            {
                Form2 Cambio1 = new Form2();
                this.Hide();
                Cambio1.Show();
            }
            else
            {
                MessageBox.Show("Nombre incorrecto");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cambio1 = new Form3();
            this.Hide();
            cambio1.Show();
        }
    }
}
