using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers.Models;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Birthday()
        {
            // create an array of strings

            // "put" the array in the ViewBag
            ViewBag.balloons = balloons;

            return View();
        }
        //creating new method birthday

        string[] balloons = { "Red", "Blue", "Green", "Purple" };

        [HttpPost]
        public ActionResult Birthday(FormCollection form)
        {
          
            @ViewBag.ResultName = form["name"];
            @ViewBag.ResultDB = form["birthday"];

            var balloon = form.AllKeys
                .Where(k => k.StartsWith("balloon"))
                .Select(k => form[k]);


            //foreach (var balloon in balloons)
            //{
            //    var b = form[balloon].Split(',');       //true, falsae
            //    var val = b[0];
            //    bool isChecked = Convert.ToBoolean(val);


            //    if (isChecked)      // if balloon checkbox is true
            //    {
            //        balloonList.Add(balloon); //add name of the balloon
            //    }
            //}

            ViewBag.BalloonList = balloon;  // storing values of checked balloons

            return View("Results");
        }


        public bool IsThisAKeyWeNeed(string x)
        {
            if (x.StartsWith("balloon"))
            
                return true;
            return false;
        }


        private List<Product> Products = new List<Product>()
        {
            new Product {id = "100", Name = "Jeans", Price = 59.99},
            new Product {id = "101", Name = "Polo", Price = 49.99}
        };

        public ActionResult DisplayProduct()
        {
            //ViewBag.ProductList = Products;

            ProductContext p = new ProductContext();
            return View(p.GetAll());
        }
    }
}