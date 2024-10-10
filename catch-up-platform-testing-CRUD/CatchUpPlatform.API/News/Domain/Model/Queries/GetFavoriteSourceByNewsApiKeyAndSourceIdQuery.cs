namespace CatchUpPlatform.API.News.Domain.Model.Queries
{
    public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string Tittle, string Url, string Description);
}