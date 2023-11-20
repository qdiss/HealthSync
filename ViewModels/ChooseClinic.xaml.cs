using HealthSync.Pages.AllHospitals;

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

    private async void GoToDomZdravlja(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DomZdravljaScreen());
    }

    private async void GoToStacionar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Stacionar());
    }

    private async void GoToPolSunce(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaSunce());
    }

    private async void GoToPolMedicom(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaMedicom());
    }

    private async void GoToPolEpion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaEpion());
    }

    private async void GoToPolNOVA(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NOVAPoliklinika());
    }

    private async void GoToPolSabic(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaSabic());
    }

    private async void GoToPolPrima(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaPrima());
    }

    private async void GoToPolZdravlje(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PoliklinikaZdravlje());
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