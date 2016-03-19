using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        // GET: api/Status
        [HttpGet]
        public IEnumerable<Status> Get()
        {
            List<Status> StatusList = new List<Status>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                StatusList = myDB.Statuses.ToList();
            }
            return StatusList;
            
        // BuyerId = 1;
        // Status BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/Status/5
        [HttpGet("{id}")]
        public Status Get(int id)
        {
            Status StatusInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 StatusInContext = myDB.Statuses.Where(t=> t.StatusId==id).First();
            }
            
            return StatusInContext;
            //var Buyers = myDB.Persons.Where(t=> t.PersonIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.Items);
            //return Buyers.First();
            
            //return "value";
        }

    }
}
