namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        // m�todo para o bot�o Voltar
        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // volta para Contrata��oHospedagem
            await Navigation.PopAsync();
        }
    }
}
