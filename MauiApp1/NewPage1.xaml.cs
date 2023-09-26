namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1(string lblUserName)
	{
		InitializeComponent();
	}
	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}