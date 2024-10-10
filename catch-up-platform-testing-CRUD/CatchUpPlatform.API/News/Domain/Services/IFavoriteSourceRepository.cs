using CatchUpPlatform.API.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.API.News.Domain.Services
{
    public interface IFavoriteSourceRepository
    {
        Task<FavoriteSource?> GetByIdAsync(int id);
        Task<FavoriteSource?> GetByNewsApiKeyAndSourceIdAsync(string Title, string Url, string Description);
        Task Update(FavoriteSource favoriteSource);
        Task Delete(int id);
        Task Add(int id);
    }
}