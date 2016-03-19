using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace BuySellBid
{
    [Route("api/[controller]")]
    public class PhotosController : Controller
    {
        // GET: api/Photo
        [HttpGet]
        public IEnumerable<Photo> Get()
        {
            List<Photo> PhotoList = new List<Photo>();
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PhotoList = myDB.Photos.ToList();
            }
            return PhotoList;
            
        // BuyerId = 1;
        // Photo BuyerEntity;
        // List<ListItem> Items;
        // bool BuyerStatus;
        
        //     return BuyerList;
        }

        // GET api/Photo/5
        [HttpGet("{id}")]
        public Photo Get(int id)
        {
            Photo PhotoInContext;
            //Buyer temp = new Buyer();
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 PhotoInContext = myDB.Photos.Where(t=> t.PhotoId==id).First();
            }
            
            return PhotoInContext;
            //var Buyers = myDB.Photos.Where(t=> t.PhotoIdId==id).Include(t=>t.BuyerEntity).Include(t=>t.Items);
            //return Buyers.First();
            
            //return "value";
        }

        // POST api/Photo
        [HttpPost]
        public void Post(Photo value)
        {
            using(BuySellBidsContext myDB = new BuySellBidsContext())
            {
                 myDB.Photos.Add(value);
                 myDB.SaveChanges();
            }
           
        }

        // PUT api/Photo/5
        [HttpPut("{id}")]
        public void Put(int id, Photo value)
        {
            Photo PhotoToUpdate;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PhotoToUpdate = myDB.Photos.Where(t=>t.PhotoId==id).First();
                myDB.Photos.Update(PhotoToUpdate);
                myDB.SaveChanges();
            }
        }

        // DELETE api/Photo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Photo PhotoToDelete;
            //Buyer temp = new Buyer();
            using( BuySellBidsContext myDB = new BuySellBidsContext())
            {
                PhotoToDelete = myDB.Photos.Where(t=>t.PhotoId==id).First();
                myDB.Photos.Remove(PhotoToDelete);
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
