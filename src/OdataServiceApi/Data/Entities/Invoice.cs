using OdataServiceApi.Data.Core;
using OdataServiceApi.Data.Enums;

namespace OdataServiceApi.Data.Entities;

public class Invoice : Entity<string>
{
    public required string Number { get; set; }
    public DateTimeOffset Date { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public DateTimeOffset? ClosedDate { get; set; }
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal CurrencyRate { get; set; }
    public required string Currency { get; set; }
    public InvoiceStatus Status { get; set; }
}
