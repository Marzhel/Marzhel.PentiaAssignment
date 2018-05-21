using System.Threading.Tasks;
using System.Web.Mvc;
using Marzhel.PentiaAssignment.Repositories;

namespace Marzhel.PentiaAssignment.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ActionResult> Index()
        {
            var customers = await _customerRepository.GetAsync();

            return View(customers);
        }

        public async Task<ActionResult> ByName(string name)
        {
            if (name == null) { return View(); }
            var customers = await _customerRepository.GetByNameAsync(name);

            return View(customers);
        }

        public async Task<ActionResult> ByStreet(string street)
        {
            if (street == null) { return View(); }
            var customers = await _customerRepository.GetByStreetAsync(street);

            return View(customers);
        }

        public async Task<ActionResult> ByPurchaseOfCarMake(string make)
        {
            if (make == null) { return View(); }
            var customers = await _customerRepository.GetByCarMakeAsync(make);

            return View(customers);
        }

        public async Task<ActionResult> ByPurchaseOfCarModel(string model)
        {
            if (model == null) { return View(); }
            var customers = await _customerRepository.GetByCarModelAsync(model);

            return View(customers);
        }

        public async Task<ActionResult> BySalesPersonName(string salesPersonName)
        {
            if (salesPersonName == null) { return View(); }
            var customers = await _customerRepository.GetBySalesPersonNameAsync(salesPersonName);

            return View(customers);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue) { return RedirectToAction(nameof(Index)); }
            var customer = await _customerRepository.GetAsync(id.Value);

            return View(customer);
        }
    }
}
