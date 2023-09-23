using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TrainingXamarin.Models;

namespace TrainingXamarin.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        
        private ArtistHit _artist;
        public ArtistHit PopularArtist
        {
            get => _artist;
            set => SetProperty(ref _artist, value);
        }
        
        public ObservableCollection<ArtistHit> TodayHits { get; } = new ObservableCollection<ArtistHit>();
        public ObservableCollection<ArtistWithListeners> ArtistWithListeners { get; } = new ObservableCollection<ArtistWithListeners>();

        public async Task RefreshPopularArtist() => PopularArtist = await HomeService.GetPopularArtistAsync();

        public async Task RefreshTodayHits()
        {
            var todayHits = await HomeService.GetTodayHitsAsync();
            TodayHits.Clear();
            todayHits.ForEach(TodayHits.Add);
        }

        public async Task RefreshArtistsList()
        {
            var artistsWithListeners = await HomeService.GetArtistsWithListenersAsync();
            ArtistWithListeners.Clear();
            artistsWithListeners.ForEach(ArtistWithListeners.Add);
        }
    }
}