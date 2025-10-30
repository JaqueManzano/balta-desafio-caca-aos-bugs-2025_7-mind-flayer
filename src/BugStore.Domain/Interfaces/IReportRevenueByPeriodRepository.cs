using BugStore.Domain.Models.Reports;

namespace BugStore.Domain.Interfaces
{
    public interface IReportRevenueByPeriodRepository
    {
        Task<List<RevenueByPeriodResult>> SearchAsync(
        string? customerName,
        string? customerEmail,
        string? productTitle,
        decimal? productPriceStart,
        decimal? productPriceEnd,
        DateTime? createdAtStart,
        DateTime? createdAtEnd,
        DateTime? updatedAtStart,
        DateTime? updatedAtEnd,
        CancellationToken cancellationToken);
    }
}
