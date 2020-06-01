using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly Context db;
        public OrderController(Context context)
        {
            this.db = context;
        }
        [HttpGet("{id}")]
        public ActionResult<Order>GetOrder(int orderID)
        {
            var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int itemID)
        {
            var item = db.Items.FirstOrDefault(i => i.ItemID == itemID);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpPost]
        public ActionResult<Order>PostOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            try
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return item;
        }
        [HttpPut("{id}")]
        public ActionResult<Order>PutOrder(int orderID,Order order)
        {
            if(orderID!=order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return (BadRequest(error));
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult<Item> PutItem(int itemID, Item item)
        {
            if (itemID != item.ItemID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return (BadRequest(error));
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int orderID)
        {
            try
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
                if(order!=null)
                {
                    db.Remove(order);
                    db.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int itemID)
        {
            try
            {
                var item = db.Items.FirstOrDefault(i => i.ItemID == itemID);
                if (item != null)
                {
                    db.Remove(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
