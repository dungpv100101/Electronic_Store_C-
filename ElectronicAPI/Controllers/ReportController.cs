using ElectronicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class ReportController : Controller
    {
        private readonly IReportService reportService;
        public ReportController(IReportService reportService)
        {
            this.reportService = reportService;
        }

        [HttpGet]
        public IActionResult GetReportData(DateTime? startDate, DateTime? toDate)
        {
            return Ok(reportService.GetReportInfo(startDate, toDate));
        }
    }
}
