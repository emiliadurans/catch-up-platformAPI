using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Domain.Repositories
{
    /// FavoriteSource Aggregate
    /// <summary>
    /// In this method, the interaction logic is created through microservices that connect to the main interface.
    /// https://learn.microsoft.com/es-es/dotnet/architecture/microservices/multi-container-microservice-net-applications/data-driven-crud-microservice
    /// </summary>
    public class FavoriteSourceRepository : IFavoriteSourceRepository
    {
        private readonly List<FavoriteSource> _favoriteSources = new();

        public Task<FavoriteSource?> GetByIdAsync(int Id)
        {
        }

        public Task<FavoriteSource?> GetByNewsApiKeyAndSourceIdAsync(string Title, string Url, string Description)
        {
        }

        public Task Add(FavoriteSource favoriteSource)
        {
        }

        public Task Update(FavoriteSource favoriteSource)
        {

        }

        public Task Delete(int id)
        {
        }
    }
}