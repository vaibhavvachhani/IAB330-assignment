using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Models
{
    public class Entry
    {
        public Entry(string imageSource, string caption, string address)
        {
            ImageSource = imageSource;
            Caption = caption;
            Address = address;
        }

        // public string Name { get; set; }
        public string ImageSource { get; set; }
            public string Caption { get; set; }
            public string Address { get; set; }
        
    }
}
