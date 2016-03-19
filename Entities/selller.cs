
using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    class seller
    {
        public long SellerId {get;set;}
        public Person Seller{get;set;}
        public List<ListItem> Items{get;set;}
        public boolean SellerStatus {get;set;}  
    }
}