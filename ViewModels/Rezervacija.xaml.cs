namespace HealthSync.Pages;

public partial class Rezervacija : ContentPage
{
	public Rezervacija()
	{
		InitializeComponent();


        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    //Navigiraj na novu stranicu
    private async void NavigateToRezervacijaDva(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RezervacijaPotvrda());
    }
}