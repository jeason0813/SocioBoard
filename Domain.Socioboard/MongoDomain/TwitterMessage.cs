﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Socioboard.MongoDomain
{
    [BsonIgnoreExtraElements]
    public class TwitterMessage
    {
        public ObjectId Id { get; set; }
        public string TwitterMsg { get; set; }
        public string MessageDate { get; set; }
    
        public string ProfileId { get; set; }
        public string FromId { get; set; }
        public string FromName { get; set; }
        public string FromProfileUrl { get; set; }
        public string ScreenName { get; set; }
        public string MessageId { get; set; }
        public string Type { get; set; }
       
        public string InReplyToStatusUserId { get; set; }
        public string SourceUrl { get; set; }
        public string FromScreenName { get; set; }
        public int ReadStatus { get; set; }
        public int IsArchived { get; set; }

        public string ProfileType
        {
            get
            {
                return "twitter";
            }
            set
            {
                value = "twitter";
            }
        }


    }
}