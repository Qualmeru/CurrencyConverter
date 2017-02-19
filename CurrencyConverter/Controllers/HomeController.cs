using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CurrencyConverter.Models;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {

            MvcApplication.currencyTable.TableView.Add(new CurrencyTable { valutaKursDatum = DateTime.Now, valueInput = 100 });


            return View();
        }
    }
}