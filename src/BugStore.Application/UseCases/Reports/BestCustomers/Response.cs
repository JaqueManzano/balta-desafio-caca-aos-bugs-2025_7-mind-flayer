namespace BugStore.Application.UseCases.Reports.BestCustomers
{
    public class Response
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int TotalOrders { get; set; }
        public decimal SpentAmount { get; set; }
    }
}
