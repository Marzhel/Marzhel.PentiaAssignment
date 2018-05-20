using System.Threading.Tasks;
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

        public async Task<ActionResult> ByName(string name)
        {
            if (name == null) { return View(); }
            var customers = await _customerService.GetByNameAsync(name);

            return View(customers);
        }

        public async Task<ActionResult> ByStreet(string street)
        {
            if (street == null) { return View(); }
            var customers = await _customerService.GetByStreetAsync(street);

            return View(customers);
        }

        public async Task<ActionResult> ByPurchaseOfCarMake(string make)
        {
            if (make == null) { return View(); }
            var customers = await _customerService.GetByCarMakeAsync(make);

            return View(customers);
        }

        public async Task<ActionResult> ByPurchaseOfCarModel(string model)
        {
            if (model == null) { return View(); }
            var customers = await _customerService.GetByCarModelAsync(model);

            return View(customers);
        }

        public async Task<ActionResult> BySalesPersonName(string salesPersonName)
        {
            if (salesPersonName == null) { return View(); }

            var customers = await _customerService.GetBySalesPersonNameAsync(salesPersonName);

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
