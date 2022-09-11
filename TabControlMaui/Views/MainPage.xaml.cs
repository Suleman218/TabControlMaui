using TabControlMaui.ViewModels;

namespace TabControlMaui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}