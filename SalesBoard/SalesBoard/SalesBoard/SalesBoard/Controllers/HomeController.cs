using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesBoard.Data;
using SalesBoard.Models;

namespace SalesBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                string Info = Request.Form["condition"];

                return View(await _context.Items.Where(c => c.Name.Contains(Info) || c.Description.Contains(Info)).ToListAsync());
            }
            catch {
                return View(await _context.Items.ToListAsync());
            }
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is a salesboard. All users can sell any products.";

            return View();
        }
        static Cookie ck = new Cookie();


        List<Cart> carts = new List<Cart>();
        public async Task<IActionResult> CartIndex()
        {
            try
            {
                List<Items> items = _context.Items.ToList();
            

                
                foreach (var item in items)
                {
                    Request.Cookies.TryGetValue(item.Id.ToString(), out string value);
                    if (!string.IsNullOrEmpty(value))
                    {
                        Cart cart = new Cart();
                        cart.Item = item.Id;
                        cart.CartId = item.Name;
                        cart.Quantity = int.Parse(value);
                        carts.Add(cart);
                    }
                }
                return View(carts);
            } catch 
            {
                List<Cart> carts = null;
                return View(carts);
            }

         
        }
        public async Task<IActionResult> Delete(int id)
        {
            var cart = carts.Find(c => c.Item == id);
            carts.Remove(cart);
            Response.Cookies.Delete(id.ToString());
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
