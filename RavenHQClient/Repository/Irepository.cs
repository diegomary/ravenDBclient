using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenHQClient.Repository
{
   public interface IRepository<T>
    {
       void Store(T obj, string databaseName);
       void Store(List<T> lstObjs, string databaseName);
       T Load(string Id, string databaseName);
       List<T> LoadAll(string databaseName);     

    }

}
