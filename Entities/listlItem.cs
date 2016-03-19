using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    class ListItem
    {
        public Item Item {get;set;}
        public int ContextStatus{get;set;}
    }
}