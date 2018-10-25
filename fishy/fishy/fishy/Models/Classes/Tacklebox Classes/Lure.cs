using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Classes.Tacklebox_Classes
{
     public class Lure
    {
        //variables
        int id;
        string brand;
        string model;        
        string lureType;
        
        int weight;
        int length;
        string colour;
        //jighead variables if soft plastic selected
        string jigheadBrand;
        int jigheadWeight;
        int jigheadHookSize;

        bool jigHeadIsVisible = false;
        //Properties
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }

        public int Weight { get => weight; set => weight = value; }
        public int Length { get => length; set => length = value; }
        public string Colour { get => colour; set => colour = value; }
        public string JigheadBrand { get => jigheadBrand; set => jigheadBrand = value; }
        public int JigheadWeight { get => jigheadWeight; set => jigheadWeight = value; }
        public int JigheadHookSize { get => jigheadHookSize; set => jigheadHookSize = value; }
        public string LureType { get => lureType; set => lureType = value; }


        public bool IsVisible { get; set; }
        public bool JigHeadIsVisible { get=>jigHeadIsVisible; set=>jigHeadIsVisible=value; }
        public int Id { get => id; set => id = value; }

        //Constructor if soft plastic not selected
        public Lure(int _id,string _brand, string _model, string _lureType, int _weight, int _length,string _colour)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            LureType = _lureType;
            Weight = _weight;
            Length = _length;
            Colour = _colour;
        }

        //soft plastic constructor
        public Lure(int _id,string _brand, string _model, string _lureType, int _weight, int _length, string _colour, string _jigHeadBrand, int _jigHeadWeight, int _jigHeadHookSize)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            Weight = _weight;
            Length = _length;
            Colour = _colour;
            JigheadBrand = _jigHeadBrand;
            JigheadWeight = _jigHeadWeight;
            JigheadHookSize = _jigHeadHookSize;
            LureType = _lureType;
            
            
        }
    }
}
