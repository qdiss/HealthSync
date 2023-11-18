namespace HealthSync.Pages;

public partial class BoardingScreen2 : ContentPage
{
    public BoardingScreen2()
    {
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void OnBoardingScreenThreeClicked(object sender, EventArgs e)
    {
        // Otvori BoardingScreen1
        await Navigation.PushAsync(new BoardingScreen3());
    }
}