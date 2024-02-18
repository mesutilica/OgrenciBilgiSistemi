using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        private readonly HttpClient _httpClient;

        public StudentsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _httpClient.GetFromJsonAsync<List<Student>>("https://localhost:7250/api/Students");
            return View(model);
        }
    }
}
