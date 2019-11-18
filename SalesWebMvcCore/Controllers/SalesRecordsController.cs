using Microsoft.AspNetCore.Mvc;
using SalesWebMvcCore.Services;
using System;
using System.Threading.Tasks;

namespace SalesWebMvcCore.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordsService _salesRecordsService;

        public SalesRecordsController(SalesRecordsService salesRecordsService)
        {
            _salesRecordsService = salesRecordsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            return View(await _salesRecordsService.FindByDateAsync(minDate, maxDate)); 
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            var teste = await _salesRecordsService.FindByDateGroupingAsync(minDate, maxDate); 
            return View(teste);
        }
    }
}