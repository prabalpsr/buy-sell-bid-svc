using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class ItemTypesController : Controller
    {
        // GET: api/ItemTypes
        [HttpGet]
        public IEnumerable<ItemType> Get()
        {
            List<ItemType> ItemTypesList = new List<ItemType>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                ItemTypesList = myDB.ItemTypes.ToList();
            }
            return ItemTypesList;
            
        // BuyerId = 1;
        // ItemType BuyerEntity;
        // List<ListItemType> ItemTypes;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/ItemType/5
        [HttpGet("{id}")]
        public ItemType Get(int id)
        {
            ItemType ItemTypeInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 ItemTypeInContext = myDB.ItemTypes.Where(t=> t.ItemTypeId==id).First();
            }
            
            return ItemTypeInContext;
            //var Buyers = myDB.ItemTypes.Where(t=> t.ItemTypeIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.ItemTypes);
            //return Buyers.First();
            
            //return "value";
        }

    }
}
