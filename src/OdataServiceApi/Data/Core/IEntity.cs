namespace OdataServiceApi.Data.Core;


public interface IEntity
{
}

public interface IEntity<T> : IEntity where T : notnull
{
    public T Id { get; set; }
}
