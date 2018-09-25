using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy.Classes.Tacklebox_Classes
{
    class Lure
    {
        //variables
        string brand;
        string model;
        public enum LureType {HardBody,SoftPlastic,Surface,BladesAndVibes,Skirted,SpinnerBait,Slug,JigLures};
        string lureTypeString;
        int weight;
        int length;
        string colour;
        //jighead variables if soft plastic selected
        string jigheadBrand;
        int jigheadWeight;
        int jigheadHookSize;

        //Properties
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string LureTypeString { get => lureTypeString; set => lureTypeString = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Length { get => length; set => length = value; }
        public string Colour { get => colour; set => colour = value; }
        public string JigheadBrand { get => jigheadBrand; set => jigheadBrand = value; }
        public int JigheadWeight { get => jigheadWeight; set => jigheadWeight = value; }
        public int JigheadHookSize { get => jigheadHookSize; set => jigheadHookSize = value; }

        //Constructor

        public Lure(string _brand, string _model, LureType _lureType, int _weight, int _length, string _colour, string _jigHeadBrand, int _jigHeadWeight, int _jigHeadHookSize)
        {
            Brand = _brand;
            Model = _model;
            Weight = _weight;
            Length = _length;
            Colour = _colour;
            JigheadBrand = _jigHeadBrand;
            JigheadWeight = _jigHeadWeight;
            JigheadHookSize = _jigHeadHookSize;

            switch (_lureType)
            {
                case LureType.HardBody:
                    LureTypeString = "Hard Body";
                    break;
                case LureType.SoftPlastic:
                    LureTypeString = "Soft Plastic";
                    break;
                case LureType.Surface:
                    LureTypeString = "Surface";
                    break;
                case LureType.BladesAndVibes:
                    LureTypeString = "Blades/ VIbes";
                    break;
                case LureType.Skirted:
                    LureTypeString = "Skirted";
                    break;
                case LureType.SpinnerBait:
                    LureTypeString = "Spinner Bait";
                    break;
                case LureType.Slug:
                    LureTypeString = "Slug";
                    break;
                case LureType.JigLures:
                    LureTypeString = "Jigging";
                    break;
                    
            }
            
        }
    }
}
