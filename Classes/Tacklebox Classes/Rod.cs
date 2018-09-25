using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy.Classes.Tacklebox_Classes
{
    public class Rod
    {
        //Variables
        int id;
        string brand;
        string model;
        int lengthfeet;
        int lengthInches;
        int weightRatingLow;
        int weightRatingHigh;
        int lureWeightLow;
        int lureWeightHigh;

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
        }

    }
}
