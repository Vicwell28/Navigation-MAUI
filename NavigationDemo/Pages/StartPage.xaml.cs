using NavigationDemo.MVVM.ViewModels;
using NavigationDemo.Utilities;

namespace NavigationDemo.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		this.BindingContext = new SendDataStartPageViewModel();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SecondPage());
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new ModalPage());
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		string data = this.txtEntry.Text;
		Navigation.PushAsync(new SendDataWithOutPage(data));
	}

	private void Button_Clicked_3(object sender, EventArgs e)
	{
		var currentViewModel =
			   ((SendDataStartPageViewModel)BindingContext);

		Navigation.PushAsync(new SendDataPage
		{
			BindingContext = currentViewModel
		}); 
	}
}