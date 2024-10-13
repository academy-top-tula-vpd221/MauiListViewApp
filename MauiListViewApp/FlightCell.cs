using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiListViewApp
{
    public class FlightCell : ViewCell
    {
        Label lblName = new(), 
              lblToCity = new(), 
              lblDate = new(), 
              lblTime = new(), 
              lblPass = new();
        Image imgAirplane = new();

        public FlightCell()
        {
            lblName.FontSize = 40;
            lblToCity.FontSize = 28;
            lblPass.FontSize = 28;
            lblDate.FontSize = 20;
            lblTime.FontSize = 20;

            HorizontalStackLayout wrapMain = new HorizontalStackLayout()
            {
                Margin = new Thickness(5)
            };
            VerticalStackLayout wrapSubOne = new VerticalStackLayout()
            {
                Margin = new Thickness(5)
            };
            HorizontalStackLayout wrapCityPass = new HorizontalStackLayout()
            {
                Margin = new Thickness(5, 0)
            };
            HorizontalStackLayout wrapDateTime = new HorizontalStackLayout()
            {
                Margin = new Thickness(5, 0)
            };
            wrapMain.Children.Add(lblName);
            wrapMain.Children.Add(wrapSubOne);

            wrapCityPass.Children.Add(lblToCity);
            wrapCityPass.Children.Add(lblPass);

            wrapDateTime.Children.Add(lblDate);
            wrapDateTime.Children.Add(lblTime);

            wrapSubOne.Children.Add(wrapCityPass);
            wrapSubOne.Children.Add(wrapDateTime);

            View = wrapMain;
        }

        public static readonly BindableProperty NameProperty =
               BindableProperty.Create("Name", typeof(string), typeof(FlightCell));

        public static readonly BindableProperty ToCityProperty =
               BindableProperty.Create("ToCity", typeof(string), typeof(FlightCell));

        public static readonly BindableProperty PassengersProperty =
               BindableProperty.Create("Passengers", typeof(int), typeof(FlightCell));

        public static readonly BindableProperty DateProperty =
               BindableProperty.Create("Date", typeof(string), typeof(FlightCell));

        public static readonly BindableProperty TimeProperty =
               BindableProperty.Create("Time", typeof(string), typeof(FlightCell));

        public static readonly BindableProperty ImageSourceProperty =
               BindableProperty.Create("ImageSource", typeof(string), typeof(FlightCell));

        public static readonly BindableProperty ImageHeightProperty =
               BindableProperty.Create("ImageHeight", typeof(int), typeof(FlightCell), 70);

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public string ToCity
        {
            get => (string)GetValue(ToCityProperty);
            set => SetValue(ToCityProperty, value);
        }

        public int Passengers
        {
            get => (int)GetValue(PassengersProperty);
            set => SetValue(PassengersProperty, value);
        }

        public string Date
        {
            get => (string)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        public string Time
        {
            get => (string)GetValue(TimeProperty);
            set => SetValue(TimeProperty, value);
        }

        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public int ImageHeight
        {
            get => (int)GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if(BindingContext is not null)
            {
                lblName.Text = Name;
                lblToCity.Text = ToCity;
                lblPass.Text = Passengers.ToString();
                lblDate.Text = Date;
                lblTime.Text = Time;
                imgAirplane.Source = ImageSource;
                imgAirplane.HeightRequest = ImageHeight;
            }
        }
    }
}
