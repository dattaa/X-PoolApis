using System;
using System.Collections.Generic;
using System.Text;

namespace CarPool.Data.ClientFactory
{
    public interface IClientProxy
    {
        object GetDBClient();

        string GetConnectionString();

        //void GetDatabase();

        void CloseDBClient();

        string GenerateAuthToken(string verb, string resourceType, string resourceId, string date, string key, string keyType, string tokenVersion);
    }
}
