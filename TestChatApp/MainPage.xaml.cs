using TestChatApp.ViewModels;

namespace TestChatApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MyBreakfastsViewModel();
    }
}


