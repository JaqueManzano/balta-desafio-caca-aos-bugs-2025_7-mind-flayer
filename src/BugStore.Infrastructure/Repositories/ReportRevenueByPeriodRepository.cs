using BugStore.Domain.Entities;
using BugStore.Domain.Interfaces;
using BugStore.Domain.Models.Reports;
using BugStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Infrastructure.Repositories
{
    public class ReportRevenueByPeriodRepository : IReportRevenueByPeriodRepository
    {
        private readonly AppDbContext _context;

        public ReportRevenueByPeriodRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<RevenueByPeriodResult>> SearchAsync(string? customerName, string? customerEmail, string? productTitle, decimal? productPriceStart, decimal? productPriceEnd, DateTime? createdAtStart, DateTime? createdAtEnd, DateTime? updatedAtStart, DateTime? updatedAtEnd, CancellationToken cancellationToken)
        {
            var data = await _context
            .Set<RevenueByPeriodResult>()
            .FromSqlRaw("SELECT * FROM sp_report_revenue_by_period({0}, {1}, ...)",
                customerName, customerEmail, productTitle,
                productPriceStart, productPriceEnd,
                createdAtStart, createdAtEnd, updatedAtStart, updatedAtEnd)
            .ToListAsync(cancellationToken);

            return data;
            ;
        }
    }
}
