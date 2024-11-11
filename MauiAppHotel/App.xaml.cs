using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto> 
        { 
            new Quarto()
            {
                Descricao = "Suite love",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 60.0
            },
            new Quarto()
            {
                Descricao = "Suite Legal",
                ValorDiariaAdulto = 90.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Baby blue",
                ValorDiariaAdulto = 170.0,
                ValorDiariaCrianca = 120.0
            },
            new Quarto()
            {
                Descricao = "Suite princesa",
                ValorDiariaAdulto = 200.0,
                ValorDiariaCrianca = 80.0
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

            window.Width = 350;
            window.Height = 600;

            return window;
        }
    }
}
