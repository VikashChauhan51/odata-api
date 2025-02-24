using OdataServiceApi.Data.Core;

namespace OdataServiceApi.Data.Enums;

public class InvoiceLine : Entity<string>
{
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public required string Currency { get; set; }
    public required string InvoiceId { get; set; }
    public Entities.Invoice Invoice { get; set; } = default!;
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
}
