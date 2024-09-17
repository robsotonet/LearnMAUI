using System.Diagnostics;

namespace LearnMAUI.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private ChildPage? _childPage;
        // Use the null-coalescing assignment operator
        public ChildPage childPage => _childPage ??= new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.ModalPopping += ModalPopping;
            Navigation.PushModalAsync(childPage);
        }
        private void ModalPopping(object? sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == childPage)
            {
                Debug.WriteLine("ParentPage: " + sender?.GetType().Name, "PS");
                App.Current.ModalPopping -= ModalPopping;
            }
        }
    }

}
