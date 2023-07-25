using NavigationDemo.Utilities;

namespace NavigationDemo.Pages;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ThirdPage());
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}