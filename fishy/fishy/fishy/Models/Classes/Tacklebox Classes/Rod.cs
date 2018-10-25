using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Classes.Tacklebox_Classes
{
    public class Rod
    {
        //Variables
        int id;
        string brand;
        string model;
        string length;
        int lengthfeet;
        int lengthInches;
        int weightRatingLow;
        int weightRatingHigh;
        string weightRating;
        int lureWeightLow;
        int lureWeightHigh;
        string lureWeight;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Lengthfeet { get => lengthfeet; set => lengthfeet = value; }
        public int LengthInches { get => lengthInches; set => lengthInches = value; }
        public int WeightRatingLow { get => weightRatingLow; set => weightRatingLow = value; }
        public int WeightRatingHigh { get => weightRatingHigh; set => weightRatingHigh = value; }
        public int LureWeightLow { get => lureWeightLow; set => lureWeightLow = value; }
        public int LureWeightHigh { get => lureWeightHigh; set => lureWeightHigh = value; }
        public string Length { get => length; set => length = value; }
        public string WeightRating { get => weightRating; set => weightRating = value; }
        public string LureWeight { get => lureWeight; set => lureWeight = value; }

        public bool IsVisible { get; set; }

        //Constructor
        public Rod(int _id, string _brand, string _model, int _lengtFeet, int _lengthInches, int _weightRatingLow, int _weightRatingHigh, int _lureWeightLow, int _lureWeightHigh)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            Lengthfeet = _lengtFeet;
            lengthInches = _lengthInches;
            WeightRatingLow = _weightRatingLow;
            WeightRatingHigh = _weightRatingHigh;
            LureWeightLow = _lureWeightLow;
            LureWeightHigh = _lureWeightHigh;
            Length = Lengthfeet + " Feet" + LengthInches + " Inches";
            WeightRating = WeightRatingLow.ToString() + "-" + WeightRatingHigh.ToString() + "Kilograms";
            LureWeight = LureWeightLow.ToString() + "-" + LureWeightHigh.ToString() + "Grams";

        }

    }
}
