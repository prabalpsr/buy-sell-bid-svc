using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class Photo
    {
        public long PhotoId{get;set;}
        public String PhotoURL{get;set;}
        public String PhotoName{get;set;}
        public Status PhotoStatus{get;set;}
     }
}