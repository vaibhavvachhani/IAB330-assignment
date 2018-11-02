using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Models
{
    public class Entry
    {
        public Entry(string imageSource, string caption, string address, string species)
        {
            ImageSource = imageSource;
            Caption = caption;
            Address = address;
            Species = species;
        }

        // public string Name { get; set; }
            public string ImageSource { get; set; }
            public string Caption { get; set; }
            public string Address { get; set; }
            public string Species { get; set; }
        
    }
}
