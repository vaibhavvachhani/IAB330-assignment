using System;
using System.Collections.Generic;
using System.Text;
using Fishy.Classes.Tacklebox_Classes;

namespace Fishy.Classes
{
    class JournalEntry
    {
        int id;
        //fish info
        string pictureLocation;
        string fishSpecies;
        int fishLength;
        int fishWeightKg;
        int fishWeightG;
               
        //Catch info
        string time;
        string date;
        string weather;
        string windDirection;
        float windSpeed;
        string tideDirection;
        float tideHeight;

        //Tackle Info
        Rod rodUsed;
        Reel reelUsed;
        Lure lureUsed;
        Line lineUsed;
        Line leaderUsed;
        TerminalTackle tackleUsed;       

        //Other
        string notes;

        //Properties
        public int Id { get => id; set => id = value; }        
        public string PictureLocation { get => pictureLocation; set => pictureLocation = value; }
        public string FishSpecies { get => fishSpecies; set => fishSpecies = value; }
        public int FishLength { get => fishLength; set => fishLength = value; }
        public int FishWeightKg { get => fishWeightKg; set => fishWeightKg = value; }
        public int FishWeightG { get => fishWeightG; set => fishWeightG = value; }
        public string Time { get => time; set => time = value; }
        public string Date { get => date; set => date = value; }
        public string Weather { get => weather; set => weather = value; }
        public string WindDirection { get => windDirection; set => windDirection = value; }
        public float WindSpeed { get => windSpeed; set => windSpeed = value; }
        public string TideDirection { get => tideDirection; set => tideDirection = value; }
        public float TideHeight { get => tideHeight; set => tideHeight = value; }
        public string Notes { get => notes; set => notes = value; }
        public Rod RodUsed { get => rodUsed; set => rodUsed = value; }
        internal Reel ReelUsed { get => reelUsed; set => reelUsed = value; }
        internal Lure LureUsed { get => lureUsed; set => lureUsed = value; }
        internal Line LineUsed { get => lineUsed; set => lineUsed = value; }
        internal Line LeaderUsed { get => leaderUsed; set => leaderUsed = value; }
        internal TerminalTackle TackleUsed { get => tackleUsed; set => tackleUsed = value; }
    }
}
