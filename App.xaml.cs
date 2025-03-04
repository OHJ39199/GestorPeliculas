using GestorPeliculas.MVVM.Views;

namespace GestorPeliculas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}
