namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = " ";
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double distancia, resultado;

            distancia = Convert.ToDouble(txtDistancia.Text);
            if(distancia <= 200)
            {
                resultado = distancia * 0.50;
            }
            else
            {
                resultado = distancia * 0.45;
            }

            txtResultado.Text = resultado.ToString();
        }
    }
}
