using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class Item
    {
        public long ItemId {get;set;}
        public String ItemName {get;set;}
        public int ItemType {get;set;}
        public String ItemLocation {get;set;}
        public String SummaryDesc {get;set;}
        public String DetailedDesc {get;set;}
        public double ItemPrice {get;set;}
        public List<Photo> Photos {get;set;}
        public long PhotoId {get;set;}
        public DateTime ListingStartDate {get;set;}
        public DateTime ListingEndDate {get;set;}
        public int ListingStatus {get;set;}    
        public bool IsBiddable{get;set;}
        public double CurrentBidAmount{get;set;}

        }
}