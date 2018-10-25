using System;
using System.Collections.Generic;
using System.Text;

namespace fishy.Classes.Tacklebox_Classes
{
    public class Reel
    {
        //Variables
        int id;
        string brand;
        string model;
        int size;
        string reelType;
        

        //Properties

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Size { get => size; set => size = value; }
        public string ReelType { get => reelType; set => reelType = value; }
        public int Id { get => id; set => id = value; }

        public bool IsVisible { get; set; }



        //Constructor
        public Reel(int _id,string _brand, string _model, int _size, string _reelType)
        {
            Id = _id;
            Brand = _brand;
            Model = _model;
            Size = _size;
            ReelType = _reelType;

        }


    }
}
