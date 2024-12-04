using MauiAppHotelTransilvania.Models;

namespace MauiAppHotelTransilvania
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCrianca = 75.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 125.0,
                ValorDiariaCrianca = 62.5
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 12.5
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
