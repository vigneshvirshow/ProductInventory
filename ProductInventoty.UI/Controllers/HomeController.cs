using Microsoft.AspNetCore.Mvc;
using ProductInventory.Infrastructure.Dto;

namespace ProductInventoty.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7198/Products");
            response.EnsureSuccessStatusCode();

            var subVariants = await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
            return View(subVariants);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
