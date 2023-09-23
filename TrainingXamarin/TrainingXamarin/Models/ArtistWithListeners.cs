using Xamarin.Forms;

namespace TrainingXamarin.Models
{
    public class ArtistWithListeners
    {
        public string Name { get; }
        public ImageSource ImageSource { get; }
        public long ListenersCount { get; }

        public ArtistWithListeners(string name, ImageSource source, long listenersCount)
        {
            Name = name;
            ImageSource = source;
            ListenersCount = listenersCount;
        }
    }
}