﻿using HashtagAggregator.Core.Models.Queries;
using HashtagAggregator.Core.Models.Results.Query.HashTag;
using MediatR;

namespace HashtagAggregator.Core.Cqrs.Interface.Queries
{
    public interface IEfHashtagGetQueryHandler : IAsyncRequestHandler<HashTagsQuery, HashTagsQueryResult>
    {

    }
}
