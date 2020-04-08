using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyExercise.Models;

namespace VidlyExercise.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>();

        public CustomersController()
        {
            customers = new List<Customer>()
            {
                new Customer(1, "Galelli"),
                new Customer(2, "Kuon"),
                new Customer(3, "Pauzor"),
                new Customer(4, "Ramoth"),
                new Customer(5, "Felaseu"),
                new Customer(6, "Dwziric")
            };
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }


        // GET: Customers/id
        public ActionResult Detail(int id)
        {
            Customer _result = customers.Find(c => c.Id == id);

            if (_result == null)
                return HttpNotFound();

            return View(_result);
        }
    }
}