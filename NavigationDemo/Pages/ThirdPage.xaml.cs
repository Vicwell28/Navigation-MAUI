using NavigationDemo.Utilities;

namespace NavigationDemo.Pages;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
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
		Navigation.PopAsync();
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		Navigation.PopToRootAsync();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		NavUtilities.DeletePage(Navigation, "StartPage");
		NavUtilities.Examine(Navigation);
	}
}