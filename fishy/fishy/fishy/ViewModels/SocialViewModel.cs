using fishy.Models;
using fishy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fishy.ViewModels
{
    public class SocialViewModel : BaseViewModel
    {
        private List<SocialPost> socialPosts;

        public List<SocialPost> SocialPosts
        {
            get { return socialPosts; }
            set
            {
                socialPosts = value;
                OnPropertyChanged();
            }
        }
        

 
        

        public SocialViewModel()
        {
            
            SocialPosts = new List<SocialPost>
            {
                new SocialPost
                {
                    Name = "@Gary",                    
                    Time = "⌛ 1w ago",
                    ImageSource = "catch1.jpg",
                    Location = "📍 - Harvey Bay, Fraser Island"

                },

                new SocialPost
                {
                    Name = "@Vaibhav",
                    Time = "⌛ 3w ago",
                    ImageSource = "catch2.jpg",
                    Location = "📍 - Arthurs Lake, Tasmania"

                },

                new SocialPost
                {
                    Name = "@Kharghan",
                    Time = "⌛ 4w ago",
                    ImageSource = "catch3.jpg",
                    Location = "📍 - Kakadu National Park, Top End"

                }
                // TODO: Add more elements to the static list

            };
        }

        
    }
    
}
