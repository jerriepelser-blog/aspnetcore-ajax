using DemoApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class Scenario2Controller : Controller
    {
        private readonly Database _database;

        public Scenario2Controller(Database database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            return View(_database.Customers);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _database.Customers.RemoveAll(customer => customer.Id == id);

            return PartialView("_CustomerList", _database.Customers);
        }
    }
}