
using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class Seller
    {
        public long SellerId {get;set;}
        public Person SellerEntity{get;set;}
        public List<ListItem> Items{get;set;}
        public bool SellerStatus {get;set;}  
    }
}