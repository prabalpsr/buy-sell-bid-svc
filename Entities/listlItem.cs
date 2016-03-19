using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class ListItem
    {
        public long ListItemId {get;set;}
        public Item Item {get;set;}
        public int ContextStatus{get;set;}
        public bool IsBiddable{get;set;}
        public double CurrentBidAmount{get;set;}
        public double AmountReceivable{get;set;}
        public double AmountPayable{get;set;}
         
    }
}