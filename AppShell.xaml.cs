namespace PopupWithFrame
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Login", typeof(PopupWithFrame.Login));
        }
    }
}
