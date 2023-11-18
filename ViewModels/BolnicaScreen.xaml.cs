namespace HealthSync.Pages;

public partial class BolnicaScreen : ContentPage
{
    public BolnicaScreen()
    {
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }
}