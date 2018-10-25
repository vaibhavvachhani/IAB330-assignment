using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Classes.Tacklebox_Classes
{
    public class Line
    {
        //Variables
        int id;
        string brand;
        string model;
        string lineType;        
        int breakingstrength;
        string lineUse;        
        

        //Properties
        public int Id { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Breakingstrength { get => breakingstrength; set => breakingstrength = value; }
        public string LineType { get => lineType; set => lineType = value; }
        public string LineUse { get => lineUse; set => lineUse = value; }
        public string Model { get => model; set => model = value; }

        public bool IsVisible { get; set; }

        //Constructor
        public Line(int _id,string _brand, string _model,string _type, int _breakingStrength, string _lineUse)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            Breakingstrength = _breakingStrength;
            LineType = _type;
            LineUse = _lineUse;
            
          

        }
    }
}
