namespace Learn04.Mobile.Views;

public partial class CommandPage : ContentPage
{
	public CommandPage()
	{
		InitializeComponent();
	}

	public void Clicked(object sender, EventArgs e)
    {
        label.Text = "Button Clicked!";
    }

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // This will get called before InitializeComponent() is called

        if (label != null)
        {
            label.Text = $"RadioButton {(sender as RadioButton).Content}: {e.Value}";
        }

        //if (e.Value)
        //{
        //    label.Text = "RadioButton Checked!";
        //}
    }
    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        label.Text = "ImageButton Clicked!";
    }
}