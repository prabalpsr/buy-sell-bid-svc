using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class PersonItemsController : Controller
    {
        // GET: api/PersonItem
        [HttpGet]
        public IEnumerable<PersonItem> Get()
        {
            List<PersonItem> PersonItemList = new List<PersonItem>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonItemList = myDB.PersonItems.ToList();
            }
            return PersonItemList;
            
        // BuyerId = 1;
        // PersonItem BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/PersonItem/5
        [HttpGet("{id}")]
        public PersonItem Get(int id)
        {
            PersonItem PersonItemInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 PersonItemInContext = myDB.PersonItems.Where(t=> t.PersonItemId==id).First();
            }
            
            return PersonItemInContext;
        }

        // GET api/PersonItem/Person/5
        [HttpGet("Person/{id}")]
        public List<PersonItem> GetItemsForPerson(int id)
        {
            List<PersonItem> PersonItemInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 PersonItemInContext = myDB.PersonItems.Where(t=> t.PersonId==id).ToList();
            }
            
            return PersonItemInContext;
        }

        // GET api/PersonItem/Item/5
        [HttpGet("Item/{id}")]
        public List<PersonItem> GetPersonsForItem(int id)
        {
            List<PersonItem> PersonItemInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 PersonItemInContext = myDB.PersonItems.Where(t=> t.ItemId==id).ToList();
            }
            
            return PersonItemInContext;
        }

        // POST api/PersonItem
        [HttpPost]
        public void Post(PersonItem value)
        {
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 myDB.PersonItems.Add(value);
                 myDB.SaveChanges();
            }
           
        }

        // PUT api/PersonItem/5
        [HttpPut("{id}")]
        public void Put(int id, PersonItem value)
        {
            PersonItem PersonItemToUpdate;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonItemToUpdate = myDB.PersonItems.Where(t=>t.PersonItemId==id).First();
                myDB.PersonItems.Update(PersonItemToUpdate);
                myDB.SaveChanges();
            }
        }

        // DELETE api/PersonItem/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonItem PersonItemToDelete;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonItemToDelete = myDB.PersonItems.Where(t=>t.PersonItemId==id).First();
                myDB.PersonItems.Remove(PersonItemToDelete);
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
