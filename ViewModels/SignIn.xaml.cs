namespace HealthSync.Pages
{
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            Console.WriteLine("SignIn page constructor called");
            InitializeComponent();

            // Postavitev da se naslovna traka (NavigationBar) ne prikazuje
            NavigationPage.SetHasNavigationBar(this, false);
        }


        // Dodajte ovu metodu koja æe se pozvati kada se pritisne "Prijavite se" na SignIn stranici
        async void NavigateToLogin(object sender, EventArgs e)
        {
            await Navigation.PopAsync().ConfigureAwait(false);
            Console.WriteLine("Navigated back to Login page from SignIn Label");
        }
    }
}
