using BugStore.Application.UseCases.Reports.RevenueByPeriod.Search;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportRevenueByPeriodController : ControllerBase
    {
        private readonly ISearchRevenueByPeriodUseCase _searchRevenueByPeriodUseCase;

        public ReportRevenueByPeriodController(ISearchRevenueByPeriodUseCase searchRevenueByPeriodUseCase)
        {
            _searchRevenueByPeriodUseCase = searchRevenueByPeriodUseCase;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] Request request, CancellationToken cancellationToken)
        {
            var result = await _searchRevenueByPeriodUseCase.ExecuteAsync(request, cancellationToken);
            return Ok(result);
        }
    }
}
