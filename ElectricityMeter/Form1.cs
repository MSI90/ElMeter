namespace ElectricityMeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out var newValue) || !int.TryParse(textBox2.Text, out var oldValue))
            {
                MessageBox.Show("Неверно указано значение");
                return;
            }

            if (newValue <= oldValue)
            {
                MessageBox.Show("Новое значение не может быть меньше, либо равным предыдущему");
                return;
            }

            int? diffKilovatt = ((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)));
            if (diffKilovatt.HasValue)
            {
                label4.Text = diffKilovatt.Value.ToString();
                label6.Text = Math.Round(diffKilovatt.Value * Settings.FeePerKilowatt, 2).ToString();
            }
            
        }
    }
}
