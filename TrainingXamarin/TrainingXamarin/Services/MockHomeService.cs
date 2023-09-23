using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingXamarin.Models;

namespace TrainingXamarin.Services
{
    public class MockHomeService: IHomeService
    {
        public Task<ArtistHit> GetPopularArtistAsync()
        {
            return Task.FromResult(new ArtistHit("Sheena Ringo", "ringo_hi_izuru.png", "Hi Izuru Tokoro"));
        }

        public Task<List<ArtistHit>> GetTodayHitsAsync()
        {
            return Task.FromResult(new List<ArtistHit>
            {
                new ArtistHit("Sheena Ringo", "ringo_hi_izuru_album.png", "Hi Izuru Tokoro"),
                new ArtistHit("EGO-WRAPPIN'", "route_20_hit_the_road.png", "Route 20 Hit The Road"),
                new ArtistHit("Tokyo Incidents", "prime_time.png", "Prime Time"),
                new ArtistHit("Sheena Ringo", "kalk_samen_kuri_no_hana.png", "Kalk Samen Kuri no Hana"),
            });
        }

        public Task<List<ArtistWithListeners>> GetArtistsWithListenersAsync()
        {
            return Task.FromResult(new List<ArtistWithListeners>
            {
                new ArtistWithListeners("Tokyo Incidents", "tokyo_jihen.png",523_464),
                new ArtistWithListeners("EGO-WRAPPIN'", "ego_wrappin.jpg",63_464),
                new ArtistWithListeners("Joji", "slow_dancing_in_the_dark.jpg", 1_587_412),
                new ArtistWithListeners("んoon", "tokyo_restaurant.jpg", 43_267),
            });
        }
    }
}