using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    class Buyer
    {
        public long BuyerId {get;set;}
        public Person Buyer{get;set;}
        public List<ListItem> Items{get;set;}
        public boolean BuyerStatus {get;set;}     
    }
}