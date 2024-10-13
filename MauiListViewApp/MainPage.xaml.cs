namespace MauiListViewApp
{
    public partial class MainPage : ContentPage
    {
        //string[] cities = ["Moscow", "St. Peterburg", "Kazan", "Novosibirsk"];
        //public List<string> Cities { set; get; }
        public List<Flight> Flights { get; set; }

        public MainPage()
        {
            InitializeComponent();

            //Cities = new() { "Moscow", "St. Peterburg", "Kazan", "Novosibirsk" };

            Flights = new()
            {
                new(){ Name = "AHJ-987", ToCity = "St.Peterburg", DateAndTime = DateTime.Now.AddDays(5).AddHours(-7), ImageSrc = "airplane01.png" },
                new(){ Name = "DS-45", ToCity = "Kazan", DateAndTime = DateTime.Now.AddDays(7).AddHours(+7), ImageSrc = "airplane02.png" },
                new(){ Name = "Y-1001", ToCity = "Novosibirsk", DateAndTime = DateTime.Now.AddDays(2).AddHours(-11), ImageSrc = "airplane01.png" },
                new(){ Name = "DWQ-87", ToCity = "Tomsk", DateAndTime = DateTime.Now.AddDays(8).AddHours(-1), ImageSrc = "airplane02.png" },
                new(){ Name = "NPR-565", ToCity = "Irkutsk", DateAndTime = DateTime.Now.AddDays(4).AddHours(+5), ImageSrc = "airplane01.png" },
            };
            //listCities.BindingContext = this;
            listCities.ItemsSource = Flights;
        }

        //private void listCities_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
        //{
        //    lblSelectedCity.Text = listCities.SelectedItem.ToString();
        //}
    }

}

