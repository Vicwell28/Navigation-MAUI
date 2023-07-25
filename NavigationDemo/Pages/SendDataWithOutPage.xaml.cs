namespace NavigationDemo.Pages;

public partial class SendDataWithOutPage : ContentPage
{
	public SendDataWithOutPage()
	{
		InitializeComponent();
	}

	public SendDataWithOutPage(string Data)
	{
		InitializeComponent();
		this.txtName.Text = Data;
	}
}