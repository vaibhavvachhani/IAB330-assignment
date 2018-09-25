using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy.Classes.Tacklebox_Classes
{
    class Reel
    {
        //Variables
        string brand;
        string model;
        string size;
        string reelTypeString;
        public enum ReelType {Spinning, BaitCaster, Overhead, Alvey };

        //Properties

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Size { get => size; set => size = value; }
        public string ReelTypeString { get => reelTypeString; set => reelTypeString = value; }

        //Constructor
        public Reel(string _brand, string _model, string _size, ReelType _reelType)
        {
            Brand = _brand;
            Model = _model;
            Size = _size;
            switch (_reelType)
            {
                case ReelType.Spinning:
                    ReelTypeString = "Spinning";
                    break;
                case ReelType.BaitCaster:
                    ReelTypeString = "Bait Caster";
                    break;
                case ReelType.Overhead:
                    ReelTypeString = "Overhead";
                    break;
                case ReelType.Alvey:
                    ReelTypeString = "Alvey";
                    break;
            }

        }


    }
}
