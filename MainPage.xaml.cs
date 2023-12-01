using CommunityToolkit.Maui.Views;

namespace PopupWithFrame
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {


            var popup = new PopupPage();
            popup.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center;
            Shell.Current.CurrentPage.ShowPopup(popup);

        }
    }

}
