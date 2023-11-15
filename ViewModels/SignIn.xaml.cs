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


        // Naviage to Login page
        async void NavigateToLogin(object sender, EventArgs e)
        {
            await Navigation.PopAsync().ConfigureAwait(false);
            Console.WriteLine("Navigated back to Login page from SignIn Label");
        }

        //Navigacija na BoardingScreen1 stranicu
        private async void OnBoardingScreenClicked(object sender, EventArgs e)
        {
            // Otvori BoardingScreen1
            await Navigation.PushAsync(new BoardingScreen1());
        }
    }
}
