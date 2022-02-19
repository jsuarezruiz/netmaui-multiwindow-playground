namespace MultiWindowPlayground;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void OnOpenWindowClicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new MainPage()));
    }

    void OnCloseWindowClicked(object sender, EventArgs e)
    {
        var window = GetParentWindow();

        if (window is not null)
            Application.Current.CloseWindow(window);
    }
}