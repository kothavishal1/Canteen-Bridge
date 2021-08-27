﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Brings_Canteen.Models;

namespace Brings_Canteen.Controllers
{
    
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Order
        // TODO : Add Admin roles to this action
        public async Task<ActionResult> Index()
        {
            var orders = db.Orders.Include(o => o.User).Include(o => o.Items);
            return View(await orders.ToListAsync());
        }

        // GET: Order/Details/5
        public async Task<ActionResult> Details()
        {
            
            string userId = User.Identity.GetUserId();

            var userOrders = await db.Orders
                .Include(order => order.Items)
                .Where(order => order.UserID == userId).ToListAsync();

            if (userOrders == null || userOrders.Count() < 1)
            {
                return View();
            }
            
            return View(userOrders);
        }

        
        public async Task<ActionResult> Delete(string id, string returnUrl)
        {
            string userId = User.Identity.GetUserId();

            Order order = await db.Orders
                .Include(ord => ord.User)
                .Include(ord => ord.Items)
                .Where(ord => ord.ID == id && ord.UserID == userId)
                .SingleOrDefaultAsync();

            List<CartItem> items = order.Items.ToList();

            items.ForEach(itm => 
            {
                itm.OrderID = null;
                db.Entry(itm).State = EntityState.Modified;
            });

          
            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return RedirectToLocalAction(returnUrl);
        }

        private ActionResult RedirectToLocalAction(string returnUrl)
        {
            if (returnUrl != null)
            {
                if (Url.IsLocalUrl(returnUrl))
                {       // If returnUrl is Local, then goto it
                    return Redirect(returnUrl);
                }
                else
                {   // If not, then return an Error View with a message in the ViewBag
                    ViewBag.ErrorMessage = "The return Url did not originate from our Server";
                    return View("Error");
                }
            }

            return RedirectToAction("Details");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
