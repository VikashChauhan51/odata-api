using Microsoft.EntityFrameworkCore;
using MR.EntityFrameworkCore.KeysetPagination;
using OdataServiceApi.Data.Core;

namespace OdataServiceApi.Query;

public static class KeysetQueryFactory
{
    private static KeysetQueryDefinition<T> MakeKeysetQuery<T, K>()
        where T : class, IEntity<K>
        where K : notnull
    {
        return KeysetQuery.Build<T>(b => b.Ascending(x => x.Id));
    }

    public static KeysetPaginationContext<TEntity> CreateContext<TEntity, TKey>(DbSet<TEntity> db, TEntity? reference)
        where TEntity : class, IEntity<TKey>
        where TKey : notnull
    {
        var keyset = MakeKeysetQuery<TEntity, TKey>();
        return reference != null
            ? db.AsNoTracking().KeysetPaginate(keyset, KeysetPaginationDirection.Forward, reference)
            : db.AsNoTracking().KeysetPaginate(keyset);

    }
}
