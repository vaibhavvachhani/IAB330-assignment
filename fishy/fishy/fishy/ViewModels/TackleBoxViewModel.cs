using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

using fishy.Models.Classes;
using fishy.Classes.Tacklebox_Classes;

namespace fishy.ViewModels
{

    public class TackleBoxViewModel
    {
        public ObservableCollection<Rod> MyRods { get; set; }
        public ObservableCollection<Reel> MyReels { get; set; }
        public ObservableCollection<Line> MyLines { get; set; }
        public ObservableCollection<Lure> MyLures { get;  set; }
        
        public TackleBoxViewModel()
        {
            MyRods = new ObservableCollection<Rod>
            {

            };
            foreach (Rod rod in TackleBoxBaseClass.rods)
            {
                rod.IsVisible = false;
                MyRods.Add(rod);
                
            }

            MyReels = new ObservableCollection<Reel>
            {

            };
            foreach (Reel reel in TackleBoxBaseClass.reels)
            {
                reel.IsVisible = false;
                MyReels.Add(reel);
            }

            MyLines = new ObservableCollection<Line>
            { };
            foreach (Line line in TackleBoxBaseClass.line)
            {
                line.IsVisible = false;
                MyLines.Add(line);
            }
            MyLures = new ObservableCollection<Lure> { };
            foreach (Lure lure in TackleBoxBaseClass.lures)
            {
                lure.IsVisible = false;
                MyLures.Add(lure);
            }



        }

        internal void HideorShowRodDetails(Rod rod)
        {
            if (!rod.IsVisible)
            {
                rod.IsVisible = true;
            }
            else
            {
                rod.IsVisible = false;
            }

            UpdateRod(rod); 
       
        }

        internal void HideorShowReelDetails(Reel reel)
        {
            if (!reel.IsVisible)
            {
                reel.IsVisible = true;
            }
            else
            {
                reel.IsVisible = false;
            }

            UpdateReel(reel);

        }

        internal void HideOrShowLineDetails(Line line)
        {
            if (!line.IsVisible)
            {
                line.IsVisible = true;
            }
            else
            {
                line.IsVisible = false;
            }
            UpdateLine(line);
        }
        internal void HideOrShowLureDetails(Lure lure)
        {
            if (!lure.IsVisible)
            {
                lure.IsVisible = true;
            }
            else
            {
                lure.IsVisible = false;
            }
            UpdateLure(lure);
        }

        private void UpdateRod(Rod rod)
        {
            var index = MyRods.IndexOf(rod);
            MyRods.Remove(rod);
            MyRods.Insert(index, rod);
        }

        private void UpdateReel(Reel reel)
        {
            var index = MyReels.IndexOf(reel);
            MyReels.Remove(reel);
            MyReels.Insert(index, reel);
        }
        private void UpdateLine(Line line)
        {
            var index = MyLines.IndexOf(line);
            MyLines.Remove(line);
            MyLines.Insert(index, line);
        }

        private void UpdateLure(Lure lure)
        {
            var index = MyLures.IndexOf(lure);
            MyLures.Remove(lure);
            MyLures.Insert(index, lure);
        }
    }
}
