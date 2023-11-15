namespace HealthSync.Pages;

public partial class BoardingScreen1 : ContentPage
{
	public BoardingScreen1()
	{
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void OnBoardingScreenTwoClicked(object sender, EventArgs e)
    {
        // Otvori BoardingScreen1
        await Navigation.PushAsync(new BoardingScreen2());
    }

    private async void GoToMain(object sender, EventArgs e)
    {
        // Otvori BoardingScreen1
        await Navigation.PushAsync(new ChooseClinic());
    }
}