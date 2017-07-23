using System;
using System.Collections;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        //set type as int b/c we're getting the genre id
        public byte Genre { get; set; }

        public IEnumerable Genres { get; set; }
        public DateTime DateTime
        {
            get
            { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}