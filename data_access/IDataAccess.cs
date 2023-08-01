using StackExchange.Redis;

namespace web_server.data_access;

public abstract class DataAccessBase<TData, TKey>
{
    protected ConnectionMultiplexer _redis_connection_multiplexer;

    public abstract void Create(TData data);

    public abstract TData Read(TKey key);

    public abstract void Update(TKey key, TData new_data);

    public abstract void Delete(TKey key);
}