using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiListViewApp
{
    public class Flight
    {
        public string? Name { get; set; }
        public string? ToCity { get; set; }
        public DateTime DateAndTime { get; set; }
        public int Passengers { get; set; }
        public string? ImageSrc { get; set; }

        public string Date 
        {
            get => DateAndTime.ToShortDateString();
        }

        public string Time
        {
            get => DateAndTime.ToShortTimeString();
        }
    }
}
