namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConverter_Click(object sender, EventArgs e)
        {
            double cotacao, dolares, reais;

            cotacao = Convert.ToDouble(txtCotacao.Text);
            dolares = Convert.ToDouble(txtDolares.Text);
            reais = cotacao * dolares;

            txtResultado.Text = reais.ToString();
        }
    }
}
