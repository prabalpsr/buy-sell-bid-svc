using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        // GET: api/Items
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            List<Item> ItemsList = new List<Item>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                ItemsList = myDB.Items.ToList();
            }
            return ItemsList;
            
        // BuyerId = 1;
        // Item BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/Item/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            Item ItemInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 ItemInContext = myDB.Items.Where(t=> t.ItemId==id).First();
            }
            
            return ItemInContext;
            //var Buyers = myDB.Items.Where(t=> t.ItemIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.Items);
            //return Buyers.First();
            
            //return "value";
        }

        // POST api/Item
        [HttpPost]
        public void Post(Item value)
        {
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 myDB.Items.Add(value);
                 myDB.SaveChanges();
            }
           
        }

        // PUT api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, Item value)
        {
            Item ItemToUpdate;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                ItemToUpdate = myDB.Items.Where(t=>t.ItemId==id).First();
                myDB.Items.Update(ItemToUpdate);
                myDB.SaveChanges();
            }
        }

        // DELETE api/Item/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item ItemToDelete;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                ItemToDelete = myDB.Items.Where(t=>t.ItemId==id).First();
                myDB.Items.Remove(ItemToDelete);
                myDB.SaveChanges();
            }
            
            // using( BuySellBidsContext myDB = new BuySellBidsContext())
            // {
            //     myDB.Entry(BuyerToDelete).State = EntityState.Deleted;    
            //     myDB.SaveChanges();
            // }
            
        }
    }
}
