﻿using System;

using MyStudyProject.Core.Contracts.Interface.Cqrs.Query;
using MyStudyProject.Shared.Contracts.Enums;

namespace MyStudyProject.Core.Models.Results.Query
{
    public class MessageQueryResult : IQueryResult
    {
        public MessageQueryResult(long id,
            string body,
            string hashtag,
            SocialMediaType mediaType,
            DateTime? postDate,
            string networkId,
            string userId)
        {
            Id = id;
            Body = body;
            HashTag = hashtag;
            MediaType = mediaType;
            PostDate = postDate;
            NetworkId = networkId;
            UserId = userId;
        }

        public MessageQueryResult()
        {  
        }

        public long Id { get; set; }

        public string Body { get; set; }

        public string HashTag { get; set; }

        public SocialMediaType MediaType { get; set; }

        public DateTime? PostDate { get; set; }

        public string NetworkId { get; set; }

        public string UserId { get; set; }


        public override bool Equals(object obj)
        {
            var query = obj as MessageQueryResult;
            if (obj == null || query == null || GetType() != query.GetType())
            {
                return false;
            }
            return Id == query.Id
                   && Body.Equals(query.Body)
                   && HashTag.Equals(query.HashTag)
                   && MediaType == query.MediaType
                   && PostDate.Equals(query.PostDate)
                   && NetworkId.Equals(query.NetworkId)
                   && UserId.Equals(query.UserId);
        }

        public override int GetHashCode()
        {
            int hashCode = 17;
            hashCode = (hashCode * 23) + Id.GetHashCode();
            hashCode = (hashCode * 23) + Body.GetHashCode();
            hashCode = (hashCode * 23) + HashTag.GetHashCode();
            hashCode = (hashCode * 23) + MediaType.GetHashCode();
            hashCode = (hashCode * 23) + PostDate.GetHashCode();
            hashCode = (hashCode * 23) + NetworkId.GetHashCode();
            hashCode = (hashCode * 23) + UserId.GetHashCode();
            return hashCode;
        }
    }
}