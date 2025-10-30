
using BugStore.Domain.Interfaces;

namespace BugStore.Application.UseCases.Reports.RevenueByPeriod.Search
{
    public class SearchRevenueByPeriodUseCase : ISearchRevenueByPeriodUseCase
    {
        private readonly IReportRevenueByPeriodRepository _reportRevenueByPeriod;

        public async Task<IEnumerable<Response>> ExecuteAsync(Request request, CancellationToken cancellationToken)
        {

            var reportData = await _reportRevenueByPeriod.SearchAsync(
                request.CustomerName,
                request.CustomerEmail,
                request.ProductTitle,
                request.ProductPriceStart,
                request.ProductPriceEnd,
                request.CreatedAtStart,
                request.CreatedAtEnd,
                request.UpdatedAtStart,
                request.UpdatedAtEnd,
                cancellationToken
            );

            return reportData.Select(r => new Response
            {
                Year = r.Year,
                Month = r.Month,
                TotalOrders = r.TotalOrders,
                TotalRevenue = r.TotalRevenue
            });
        }
    }
}
