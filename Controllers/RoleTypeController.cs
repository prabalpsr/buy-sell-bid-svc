using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class RoleTypesController : Controller
    {
        // GET: api/RoleType
        [HttpGet]
        public IEnumerable<RoleType> Get()
        {
            List<RoleType> RoleTypeList = new List<RoleType>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                RoleTypeList = myDB.RoleTypes.ToList();
            }
            return RoleTypeList;
            
        // BuyerId = 1;
        // RoleType BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerRoleType;
        
        //     return BuyerList;
        }

        // GET api/RoleType/5
        [HttpGet("{id}")]
        public RoleType Get(int id)
        {
            RoleType RoleTypeInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 RoleTypeInContext = myDB.RoleTypes.Where(t=> t.RoleTypeId==id).First();
            }
            
            return RoleTypeInContext;
            //var Buyers = myDB.Persons.Where(t=> t.PersonIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.Items);
            //return Buyers.First();
            
            //return "value";
        }

    }
}
