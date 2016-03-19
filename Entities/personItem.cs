
using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class PersonItem
    {
        public long PersonItemId {get;set;}
        public long PersonId {get;set;}
        public RoleType RoleType {get;set;}
        public Item ItemId{get;set;}
        public Status PersonItemStatus {get;set;}  
        
        public DateTime ItemBuySellBidDateTime {get;set;}
        
        public double AmountRecievablePayable{get;set;}
        
        public double BidAmount{get;set;}
         
    }
}