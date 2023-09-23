using Xamarin.Forms;

namespace TrainingXamarin.Models
{
    public class ArtistHit
    {
        public string Name { get; }
        public ImageSource Image { get; }
        public string Album { get; }

        public ArtistHit(string name, ImageSource image, string album)
        {
            Name = name;
            Image = image;
            Album = album;
        }

        public override string ToString()
        {
            return $"PopularArtist(Name={Name}, Image={Image}, Album={Album})";
        }
    }
}