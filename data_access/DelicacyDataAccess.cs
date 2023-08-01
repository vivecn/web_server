using web_server.models;
using web_server.utils;

namespace web_server.data_access;

public class DelicacyDataAccess : DataAccessBase<Delicacy, string>
{
    public DelicacyDataAccess()
    {
        _redis_connection_multiplexer = DataBase.GetRedisConnection();
    }

    public override void Create(Delicacy data)
    {
        throw new NotImplementedException();
    }

    public override Delicacy Read(string key)
    {
        throw new NotImplementedException();
    }

    public override void Update(string key, Delicacy new_data)
    {
        throw new NotImplementedException();
    }

    public override void Delete(string key)
    {
        throw new NotImplementedException();
    }
}