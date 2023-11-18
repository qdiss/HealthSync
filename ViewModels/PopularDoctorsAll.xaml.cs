namespace HealthSync.Pages;

public partial class PopularDoctorsAll : ContentPage
{
	public PopularDoctorsAll()
	{
		InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }

    //Prebaci na stranicu za prikaz doktora
    private async void NavigateToRezervacija(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DoctorDetails());
    }
}