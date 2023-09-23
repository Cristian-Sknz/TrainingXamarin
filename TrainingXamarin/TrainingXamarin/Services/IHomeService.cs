using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingXamarin.Models;

namespace TrainingXamarin.Services
{
    public interface IHomeService
    {
        Task<ArtistHit> GetPopularArtistAsync();
        Task<List<ArtistHit>> GetTodayHitsAsync();
        Task<List<ArtistWithListeners>> GetArtistsWithListenersAsync();
    }
}