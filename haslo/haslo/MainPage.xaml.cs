namespace haslo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string haslo = "";
        async void zatwierdz(object sender, EventArgs e)
        {
            await DisplayAlert("Dane pracownika:",$"{imie.Text}, {nazwisko.Text}, {stanowisko.SelectedItem}, hasło:{haslo}","OK");
        }
        private void generujHaslo(object sender, EventArgs e)
        {
            haslo = "";
            var litery = "abcdefghijklmnopqrstuvwxyz";
            var cyfry = "0123456789";
            var wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var specjalne = "!@#$%^&*()_+-=";
            var n = Int32.Parse(ileZnakow.Text);
            Random random = new Random();
            if (wielkieCb.IsChecked == true)
            {
                int w = random.Next(wielkieLitery.Length);
                haslo += wielkieLitery[w];
                n--;
            }
            if (cyfryCb.IsChecked == true)
            {
                int c = random.Next(cyfry.Length);
                haslo += cyfry[c];
                n--;
            }
            if (specjalneCb.IsChecked == true)
            {
                int s = random.Next(specjalne.Length);
                haslo += specjalne[s];
                n--;
            }
            for (int i = 0; i < n; i++) {
                
                int l = random.Next(litery.Length);
                haslo += litery[l];
                
            }
        }
    }

}
