using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    class Item
    {
        public long ItemId {get;set;}
        public String ItemName {get;set;}
        public int ItemType {get;set;}
        public String ItemLocation {get;set;}
        public String SummaryDesc {get;set;}
        public String DetailedDesc {get;set;}
        public double ItemPrice {get;set;}
        public List<Photo> Photos {get;set;}
        public Photo DefaultPhoto{get;set;}
        public Date ListingStartDate {get;set;}
        public Date ListingEndDate {get;set;}
        public int ListingStatus {get;set;};    
        }
}