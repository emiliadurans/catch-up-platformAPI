﻿using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Application.Internal
{
    public class FavoriteSourceQueryService: IFavoriteSourceQueryService
    {
        public Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
