using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CarPool.Data.ClientFactory
{
    public class MongoDbProvider:IClientProxy
    {
        public void CloseDBClient()
        {
            //return (object)(new MongoClient(ConfigurationSettings.AppSettings.Get("MySetting").ToString()));
        }

        public string GenerateAuthToken(string verb, string resourceType, string resourceId, string date, string key, string keyType, string tokenVersion)
        {
            throw new NotImplementedException();
        }

        public string GetConnectionString()
        {
            return @"";
        }
        
        public object GetDBClient()
        {
            return (object)(new MongoClient(GetConnectionString()));
        }
    }
}
