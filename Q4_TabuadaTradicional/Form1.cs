namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, i;
            int[] tabuada = new int[10];

            numero = Convert.ToInt32(txtNumero.Text);
            for(i = 1; i <= 10; i++)
            {
                lstTabuada.Items.Add(numero +" X "+ i +" = "+ numero * i);
            }
      
        }
    }
}
