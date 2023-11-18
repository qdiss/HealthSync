namespace HealthSync.Pages;

public partial class PopularDoctor : ContentPage
{
    public PopularDoctor()
    {
        InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void NavigateToAllPopularDoctors(object sender, EventArgs e)
    {
        // Implementirajte kod za navigaciju na drugu stranicu ovdje
        await Navigation.PushAsync(new PopularDoctorsAll());
    }
}