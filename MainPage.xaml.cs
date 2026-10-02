namespace CalculadoraX
{
    
    public partial class MainPage : ContentPage
    {
        int gorjeta = 0;
        int compra = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        

        private void Gorjeta15PorcentoButton_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Gorjeta20PorcentoButton_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }


        private void ArredondarPraBaixo(object sender, EventArgs e)
        {
            double valorGorjeta = Convert.ToDouble(ValorGorjetaLabel.Text);
            double gorjetaArredondada = Math.Floor(valorGorjeta);
            ValorGorjetaLabel.Text = gorjetaArredondada.ToString();


            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double valorTotal = valorDaConta + gorjetaArredondada;
            ValorTotalLabel.Text = valorTotal.ToString();
        }

        private void ArredondarParaCimaButton_Clicked(object sender, EventArgs e)
        {
            double valorGorjeta = Convert.ToDouble(ValorGorjetaLabel.Text);
            double gorjetaArredondada = Math.Ceiling(valorGorjeta);
            ValorGorjetaLabel.Text = gorjetaArredondada.ToString();


            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double valorTotal = valorDaConta + gorjetaArredondada;
            ValorTotalLabel.Text = valorTotal.ToString();
        }

        private void SliderGorjeta_ValueChanged(object sender, ValueChangedEventArgs e)
        {
                
            PorcentagemGorjetaLabel.Text = $"{PorcentagemSlider.Value}" + "%";
            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double porcentagemDaGorjeta = PorcentagemSlider.Value/100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            ValorGorjetaLabel.Text = Convert.ToString(valorDaGorjeta);
            double valorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalLabel.Text = valorTotal.ToString();



        }
    }
}