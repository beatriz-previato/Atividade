namespace Q1_ConversorCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConverter_Click(object sender, EventArgs e)
        {
            double c, f;
            c = Convert.ToDouble(txtCelsius.Text);
            f = (c * 9 / 5) + 32;
            txtFah.Text = f.ToString();
        }
    }
}
