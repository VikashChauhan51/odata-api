namespace OdataServiceApi.Data.Enums;

public enum InvoiceStatus : byte
{
    Draft = 0,
    Open = 1,
    Closed = 2,
    Paid = 3,
    Overdue = 4,
    Cancelled = 5
}
