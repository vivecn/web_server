using StackExchange.Redis;

namespace web_server.utils;

public static class DataBase
{
    private const string _CONFIGURATION = "localhost";

    public static ConnectionMultiplexer GetRedisConnection()
    {
        var redis_connection = ConnectionMultiplexer.Connect(_CONFIGURATION);
        return redis_connection;
    }
}