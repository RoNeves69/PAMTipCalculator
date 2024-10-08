﻿namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTip_Clicked(System.Object sender, EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void SetHighTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 25;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 50;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void TipSlider_ValueChanged(System.Object sender, System.EventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Pagar o valor inserido ex: 100
            //Calcular o valor da gorjeta de acordo com a porcentagem
            //Calcular o valor total, sendo a soma do valor + a gorjeta 

            double Valor = Convert.ToDouble(AmountEntry.Text);
            double ValorDaGorjeta = Valor * (TipSlider.Value/100);
            double ValorTotal = ValorDaGorjeta + Valor;

            TotalLabel.Text = ValorTotal.ToString();
            TipLabel.Text = ValorDaGorjeta.ToString();

        }
    }

}
