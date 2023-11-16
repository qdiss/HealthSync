namespace HealthSync.Pages;

public partial class PopularDoctor : ContentPage
{
	public PopularDoctor()
	{
		InitializeComponent();

        // NavBar sakrivanje
        NavigationPage.SetHasNavigationBar(this, false);
    }
}