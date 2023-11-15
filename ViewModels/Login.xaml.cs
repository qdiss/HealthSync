namespace HealthSync.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            // NavBar sakrivanje
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //Navigacija na SignUp stranicu
        async void NavigateToSignIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn()).ConfigureAwait(false);
            Console.WriteLine("Navigated to SignIn page");
        }

        //Navigacija na Main stranicu
        private async void NavigateToMain(object sender, EventArgs e)
        {
            // Otvori BoardingScreen1
            await Navigation.PushAsync(new ChooseClinic());
        }

    }
}
