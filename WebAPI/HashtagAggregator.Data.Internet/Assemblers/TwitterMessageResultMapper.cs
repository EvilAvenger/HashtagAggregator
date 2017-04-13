﻿using System.Collections.Generic;
using HashtagAggregator.Core.Models.Results.Query;
using HashtagAggregator.Core.Models.Results.Query.Message;
using HashtagAggregator.Core.Models.Results.Query.User;
using HashtagAggregator.Shared.Contracts.Enums;
using Tweetinvi.Models;

namespace HashtagAggregator.Data.Internet.Assemblers
{
    public class TwitterMessageResultMapper
    {
        public MessagesQueryResult MapBunch(IEnumerable<ITweet> messages, string hashtag)
        {
            var results = new MessagesQueryResult();
            if (messages != null)
            {
                foreach (var tweet in messages)
                {
                    var message = MapSingle(tweet, hashtag);
                    results.Messages.Add(message);
                }
            }
            return results;
        }

        public MessageQueryResult MapSingle(ITweet tweet, string hashtag)
        {
            UserQueryResult user = new UserQueryResult
            {
                NetworkId = tweet.CreatedBy.IdStr,
                Url = tweet.Url,
                UserName = tweet.CreatedBy.Name,
                AvatarUrl50 = tweet.CreatedBy.ProfileImageUrl,
                MediaType = SocialMediaType.Twitter
            };

            MessageQueryResult message = new MessageQueryResult(0,
                tweet.Text,
                hashtag,
                SocialMediaType.Twitter,
                tweet.TweetLocalCreationDate.ToUniversalTime(),
                tweet.IdStr,
                user);
            return message;
        }
    }
}