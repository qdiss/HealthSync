
using System.Globalization;


namespace HealthSync.Pages
{
    public partial class SearchDoctorTime : ContentPage
    {
        public SearchDoctorTime()
        {
            InitializeComponent();


            // NavBar sakrivanje
            NavigationPage.SetHasNavigationBar(this, false);

            // Postavi trenutni datum
            DateTime currentDate = DateTime.Now;

            // Postavi TodayLabel za Danas Datum i Mjesec
            TodayLabel = $"Danas, {currentDate.Day} {ToTitleCase(currentDate.ToString("MMM", new CultureInfo("bs-Latn-BA")))}";

            // Postavi TomorrowLabel za Sutra Datum i Mjesec
            DateTime tomorrowDate = currentDate.AddDays(1);
            TomorrowLabel = $"Sutra, {tomorrowDate.Day} {ToTitleCase(tomorrowDate.ToString("MMM", new CultureInfo("bs-Latn-BA")))}";

            // DayAfterTomorrowLabel za Prekosutra Datum i Mjesec
            DateTime dayAfterTomorrowDate = currentDate.AddDays(2);
            DayAfterTomorrowLabel = $"Prekosutra, {dayAfterTomorrowDate.Day} {ToTitleCase(dayAfterTomorrowDate.ToString("MMM", new CultureInfo("bs-Latn-BA")))}";

            // NextAvailabilityText za gumb na sljedeæu dostupnost
            DateTime nextAvailabilityDate = currentDate.AddDays(1);
            NextAvailabilityText = $"Sljedeæa dostupnost: {ToTitleCase(nextAvailabilityDate.ToString("dddd", new CultureInfo("bs-Latn-BA")))}, {nextAvailabilityDate.ToString("dd", new CultureInfo("bs-Latn-BA"))}. {ToTitleCase(nextAvailabilityDate.ToString("MMM", new CultureInfo("bs-Latn-BA")))}";

            // BindingContext povezivanje s XAML-om
            BindingContext = this;
        }

        public string TodayLabel { get; set; }
        public string TomorrowLabel { get; set; }
        public string DayAfterTomorrowLabel { get; set; }
        public string NextAvailabilityText { get; set; }


        // Pretvaranje prvog slova u veliko, a ostalih u mala slova
        private string ToTitleCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }


        // Navigacija na sljedeæu dostupnost
        private async void NavigateToDoctorTimePick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctorTimePick());
        }
    }
}
