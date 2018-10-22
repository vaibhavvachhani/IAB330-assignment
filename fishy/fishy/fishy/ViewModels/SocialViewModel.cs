using fishy.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
                    Name = "username",                    
                    Time = "one week ago",
                    ImageSource = "catch1.jpg",
                    Location = "reserve park"
                    
                },

                 new SocialPost
                {
                    Name = "username2",
                    Time = "three weeks ago",
                    ImageSource = "catch2.jpg",
                    Location = "another park"

                }

                // TODO: Add more elements to the static list

            };
        }
    }
    
}
