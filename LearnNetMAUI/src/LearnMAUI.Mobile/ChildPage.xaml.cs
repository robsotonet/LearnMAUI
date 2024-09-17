namespace LearnMAUI.Mobile;

public partial class ChildPage : ContentPage
{
	public ChildPage()
	{
		InitializeComponent();
	}


    private void Button_Clicked(object? sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}