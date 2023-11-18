namespace HealthSync.Pages;

public partial class DoctorDetails : ContentPage
{
	public DoctorDetails()
	{
		InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    //Navigiraj na novu stranicu
    private async void NavigateToRezervacija(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Rezervacija());
    }
}