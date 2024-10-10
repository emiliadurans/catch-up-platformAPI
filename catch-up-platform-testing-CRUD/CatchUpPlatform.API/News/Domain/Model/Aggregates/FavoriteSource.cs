namespace CatchUpPlatform.API.News.Domain.Model.Aggregates
{
    /// FavoriteSource Aggregate
    /// <summary>
    /// This class represents the FavoriteSource aggregate. It is used to store the favorite sources of a user and initialize variables.
    /// This class protected to ghanges to values.
    /// </summary>
    public class FavoriteSource
    {
        public int Id { get; private set; }
        public string Tittle { get; private set; }
        public string Url { get; private set; }
        public string Description { get; private set; }

        public FavoriteSource()
        {
            this.Tittle = string.Empty;
            this.Url = string.Empty;
            this.Description = string.Empty;
        }
    }
}
