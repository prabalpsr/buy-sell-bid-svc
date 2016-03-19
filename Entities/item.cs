using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace BuySellBid
{
    Class Item
    {
        long ItemId {get;set;};
        String ItemName {get;set;};
        int ItemType {get;set;};
        String ItemLocation {get;set;};
        String SummaryDesc {get;set;};
        String DetailedDesc {get;set;};
        double ItemPrice {get;set;};
        List<Photo> Photos {get;set;};
        Photo DefaultPhoto{get;set;};
        Date ListingStartDate {get;set;};
        Date ListingEndDate {get;set;};
        int ListingStatus {get;set;};    }
}