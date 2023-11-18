namespace HealthSync.Pages;

public partial class DoctorDetails : ContentPage
{
	public DoctorDetails()
	{
		InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }
}