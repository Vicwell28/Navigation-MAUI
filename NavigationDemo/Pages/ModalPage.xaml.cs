namespace NavigationDemo.Pages;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

	protected override bool OnBackButtonPressed()
	{
		return true;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}