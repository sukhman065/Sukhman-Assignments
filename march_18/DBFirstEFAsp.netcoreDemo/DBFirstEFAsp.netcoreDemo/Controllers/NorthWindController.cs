using Microsoft.AspNetCore.Mvc;
using DBFirstEFAsp.netcoreDemo.Models;

namespace DBFirstEFAsp.netcoreDemo.Controllers
{
    public class NorthWindController : Controller
    {
       
        public IActionResult SpainCustomers()
        {
            NORTHWNDContext cnt = new NORTHWNDContext();
            var spaincustomer = cnt.Customers.Where(x => x.Country == "Spain").
                Select(x => new SpainCustomerViewModel
                { Cid= x.CustomerId, 
                 Cname=x.ContactName, 
                 Comname=x.CompanyName
                })
                .ToList();
                
            return View(spaincustomer);
        }

        public IActionResult searchCustomer(string contactname)
        {
            NORTHWNDContext cnt = new NORTHWNDContext();
            var searchcustomer = from customer in cnt.Customers
                                 where customer.ContactName == contactname
                                 select new Customer
                                 {
                                     ContactName = customer.ContactName,
                                     ContactTitle = customer.ContactTitle,
                                     CompanyName = customer.CompanyName
                                 };
            var searchcustomer2 = cnt.Customers.Where(x => x.ContactName == contactname)
                .Select(x => new Customer
                {
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                    CompanyName = x.CompanyName
                });


            var query1 = searchcustomer.Single();
            var query2 = searchcustomer2.Single();
            return View(query1); // or query2 can be used

        }

        public ActionResult ProductsInCategory(string categoryname)
        {
            NORTHWNDContext cnt = new NORTHWNDContext();
            var productsinCategory = cnt.Products
    .Where(x => x.Category.CategoryName.Contains(categoryname))
    .Select(x => new ProdCat
    {
        prodname = x.ProductName,
        catname = x.Category.CategoryName
    }).ToList();
            return View(productsinCategory);
        }
        public ActionResult OrderRange(string range)
        {
            NORTHWNDContext cnt = new NORTHWNDContext();
            var range1 = Convert.ToInt16(range);
            var custOrderCount = cnt.Customers
                .Where(x => x.Orders.Count > range1)
                .Select(x => new Customer
                {
                    CustomerId=x.CustomerId,
                    ContactName=x.ContactName,
                });
            return View(custOrderCount);
        }

        public IActionResult CustomerOrderDetails(string id)
        {
            NORTHWNDContext cnt = new NORTHWNDContext();
            var orders = cnt.Orders
                .Where(o => o.CustomerId == id)
                .Select(o => new Order
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate,
                    RequiredDate = o.RequiredDate,
                    ShippedDate = o.ShippedDate
                }).ToList();

            ViewBag.CustomerId = id;

            return View(orders);
        }
    }
}
