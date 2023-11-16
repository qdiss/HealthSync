namespace HealthSync.Pages;

public partial class ChooseClinic : ContentPage
{
	public ChooseClinic()
	{
		InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void GoToBolnica(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BolnicaScreen());
    }

    private async void OnSearchButtonPressed(object sender, EventArgs e)
    {
        // Ova metoda æe se pozvati kada korisnik pritisne dugme za pretragu na tastaturi dok je fokusiran na SearchBar.
        await NavigateToSearchResults();
    }

    private async Task NavigateToSearchResults()
    {
        await Navigation.PushAsync(new SearchDoctor());
    }

    private async void NavigateToPopular(object sender, EventArgs e)
    {
        // Implementirajte kod za navigaciju na drugu stranicu ovdje
        await Navigation.PushAsync(new PopularDoctor());
    }



}