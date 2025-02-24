namespace OdataServiceApi.Resources;

public interface IResource
{
}

public interface IResource<T> : IResource
    where T : notnull
{
    public T Id { get; set; }
}
