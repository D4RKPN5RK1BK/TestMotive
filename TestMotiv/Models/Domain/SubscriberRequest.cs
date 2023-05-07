﻿using TestMotiv.Abstractions;

namespace TestMotiv.Models.Domain
{
    public class SubscriberRequest : IHasId
    {
        public int Id { get; set; }
        
        public string Phone { get; set; }
        
        public Country Country { get; set; }
        
        public int CountryId { get; set; }
        
        public Region Region { get; set; }

        public int RegionId { get; set; }
        
        public City City { get; set; }
        
        public int CityId { get; set; }
        
        public RequestReason RequestReason { get; set; }
        
        public int RequestReasonId { get; set; }
    }
}