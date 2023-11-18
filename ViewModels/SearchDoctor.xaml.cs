namespace HealthSync.Pages;

public partial class SearchDoctor : ContentPage
{
    public SearchDoctor()
    {
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void SelectTime(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchDoctorTime());
    }
}