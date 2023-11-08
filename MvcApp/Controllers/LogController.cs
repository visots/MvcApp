using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class LogController : Controller
    {
        private readonly ILoggerRepository _repo;

        public LogController(ILoggerRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var log = await _repo.GetLog();
            return View(log);
        }
    }
}
