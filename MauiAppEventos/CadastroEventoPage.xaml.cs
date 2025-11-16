
namespace MauiAppEventos
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
            BindingContext = new Evento();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;
            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }
}