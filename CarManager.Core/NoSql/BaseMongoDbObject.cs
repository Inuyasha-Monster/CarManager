using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.NoSql
{
    [Serializable]
    public class BaseMongoDbObject
    {
        public ObjectId Id { get; set; }
    }
}
