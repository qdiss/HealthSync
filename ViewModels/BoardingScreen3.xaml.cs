namespace HealthSync.Pages;

public partial class BoardingScreen3 : ContentPage
{
    public BoardingScreen3()
    {
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void NavigateToChooseClinic(object sender, EventArgs e)
    {
        // Otvori Choose Clinic
        await Navigation.PushAsync(new ChooseClinic());
    }
}