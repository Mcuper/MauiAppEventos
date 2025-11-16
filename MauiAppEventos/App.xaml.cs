
namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Define a primeira página do app como sendo a de cadastro,
            // dentro de um NavigationPage (para permitir ir e voltar entre telas)
            MainPage = new NavigationPage(new CadastroEventoPage());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}