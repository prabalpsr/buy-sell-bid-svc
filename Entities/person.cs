using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    public class Person
    {
        public long PersonId {get;set;}
        public String Name {get;set;}
        public String UserId {get;set;}
        public bool PersonStatus {get;set;}
        public String PhoneNo {get;set;}
        public String EmailId {get;set;}
        public String ChatId {get;set;}
    }
}