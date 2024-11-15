namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        // método para o botão Voltar
        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // volta para ContrataçãoHospedagem
            await Navigation.PopAsync();
        }
    }
}
