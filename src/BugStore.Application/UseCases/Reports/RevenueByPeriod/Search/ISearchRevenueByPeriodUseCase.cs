namespace BugStore.Application.UseCases.Reports.RevenueByPeriod.Search
{
    public interface ISearchRevenueByPeriodUseCase
    {
        Task<IEnumerable<Response>> ExecuteAsync(Request request, CancellationToken cancellationToken);
    }
}
