using GestorPeliculas.MVVM.ViewModels;

namespace GestorPeliculas.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel _vn = new MainViewModel();
	public MainView()
	{
		InitializeComponent();
        BindingContext = _vn;
    }
}