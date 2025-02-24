namespace OdataServiceApi.Data.Core;

public abstract class Entity<T> : IEntity<T> where T : notnull
{
    public T Id { get; set; } = default!;
}
