using fishy.Classes.Tacklebox_Classes;
using fishy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace fishy.Models.Classes
{
   public static class TackleBoxBaseClass
    {
        private static  List<Rod> Rods = new List<Rod>();
        private static List<Reel> Reels = new List<Reel>();
        private static List<Line> Line = new List<Line>();
        private static List<Lure> Lures = new List<Lure>();
        

        public static List<Rod> rods { get => Rods; set => Rods = value; }
        public static List<Reel> reels { get => Reels; set => Reels = value; }
        public static List<Line> line { get => Line; set => Line = value; }
        public static List<Lure> lures { get => Lures; set => Lures = value; }
    }
}
