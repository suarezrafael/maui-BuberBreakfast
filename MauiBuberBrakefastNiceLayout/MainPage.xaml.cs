using MauiBuberBrakefastNiceLayout.ViewModels;

namespace MauiBuberBrakefastNiceLayout;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		//InitializeComponent();
		BindingContext = new MyBreakfastViewModel();
	}


}

