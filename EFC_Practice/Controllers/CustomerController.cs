using EFC_Practice.Data;
using EFC_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFC_Practice.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            IEnumerable<Customer> customer = _db.Customers;
            return View(customer);
        }
    }
}
