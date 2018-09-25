using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy.Classes.Tacklebox_Classes
{
    class Line
    {
        //Variables
        string brand;
        public enum Type {Flurocarbon, Monofilament, Braid }
        string typeString;
        int breakingstrength;
        public enum Use {Mainline, Leaderline };
        string useString;

        //Properties
        public string Brand { get => brand; set => brand = value; }
        public int Breakingstrength { get => breakingstrength; set => breakingstrength = value; }
        public string TypeString { get => typeString; set => typeString = value; }
        public string UseString { get => useString; set => useString = value; }

        //Constructor
        public Line(string _brand, Type _type, int _breakingStrength, Use _use)
        {
            Brand = _brand;

            switch (_type)
            {
                case Type.Flurocarbon:
                    TypeString = "Flurocarbon";
                    break;
                case Type.Monofilament:
                    TypeString = "Monofilament";
                    break;
                case Type.Braid:
                    TypeString = "Braid";
                    break;
                    
            }

            Breakingstrength = _breakingStrength;

            switch (_use)
            {
                case Use.Mainline:
                    UseString = "Main Line";
                    break;

                case Use.Leaderline:
                    UseString = " Leader Line";
                    break;
            }

        }
    }
}
