using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class Buyer
    {
        public long BuyerId {get;set;}
        public Person BuyerEntity{get;set;}
        public List<ListItem> Items{get;set;}
        public bool BuyerStatus {get;set;}     
    }
}