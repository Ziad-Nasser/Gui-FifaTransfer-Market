using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Transfer_Market
{
    public class ClubImageManager
    {
        private Dictionary<string, string> clubImages = new Dictionary<string, string>();

        public ClubImageManager()
        {
            InitializeClubImages();
        }

        private void InitializeClubImages()
        {
            // Add more clubs and their image paths
            clubImages.Add("Man United", "..\\image\\Clubs\\ManUnited.jpg");
            clubImages.Add("Man City", "path_to_man_city_image");
            // Add more clubs and their image paths

            // You can continue adding more clubs and images here
        }

        public Image GetClubImage(string clubName)
        {
            if (clubImages.ContainsKey(clubName))
            {
                try
                {
                    // Get the corresponding image path
                    string imagePath = clubImages[clubName];

                    // Load the image
                    return Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image for club {clubName}: {ex.Message}");
                }
            }

            // Return null if the image is not found
            return null;
        }
        public string[] GetClubNames()
        {
            // Return an array of club names
            return new List<string>(clubImages.Keys).ToArray();
        }
    }
}
