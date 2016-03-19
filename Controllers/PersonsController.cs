using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> PersonList = new List<Person>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonList = myDB.Persons.ToList();
            }
            return PersonList;
            
        // BuyerId = 1;
        // Person BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/Person/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            Person PersonInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 PersonInContext = myDB.Persons.Where(t=> t.PersonId==id).First();
            }
            
            return PersonInContext;
            //var Buyers = myDB.Persons.Where(t=> t.PersonIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.Items);
            //return Buyers.First();
            
            //return "value";
        }

        // POST api/Person
        [HttpPost]
        public void Post(Person value)
        {
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 myDB.Persons.Add(value);
                 myDB.SaveChanges();
            }
           
        }

        // PUT api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, Person value)
        {
            Person PersonToUpdate;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonToUpdate = myDB.Persons.Where(t=>t.PersonId==id).First();
                myDB.Persons.Update(PersonToUpdate);
                myDB.SaveChanges();
            }
        }

        // DELETE api/Person/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Person PersonToDelete;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PersonToDelete = myDB.Persons.Where(t=>t.PersonId==id).First();
                myDB.Persons.Remove(PersonToDelete);
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
