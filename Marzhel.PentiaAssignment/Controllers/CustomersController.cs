using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Marzhel.PentiaAssignment.Services;

namespace Marzhel.PentiaAssignment.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<ActionResult> Index()
        {
            var customers = await _customerService.GetAsync();

            return View(customers);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue) { return RedirectToAction(nameof(Index)); }

            var customer = await _customerService.GetAsync(id.Value);

            return View(customer);
        }
    }
}
