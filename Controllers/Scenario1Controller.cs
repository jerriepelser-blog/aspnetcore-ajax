using DemoApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class Scenario1Controller : Controller
    {
        private readonly Database _database;

        public Scenario1Controller(Database database)
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

            return NoContent();
        }
    }
}