using Raven.Client.Document;
using Raven.Client;
using Raven.Client.Extensions;
using RavenHQClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenHQClient.Repository
{
    public class Repository<T> : IRepository<T> where T :class
    {
   
        public void Store(T obj,string databaseName)
        {
            var documentStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            documentStore.Initialize();
            documentStore.DatabaseCommands.EnsureDatabaseExists(databaseName); // Create the Db if it doesn't exist
            using (IDocumentSession session = documentStore.OpenSession(databaseName))
            {
                session.Store(obj); 
                session.SaveChanges();
            }
        }


        public void Store(List<T> lstObjs, string databaseName)
        {
            var documentStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            documentStore.Initialize();
            documentStore.DatabaseCommands.EnsureDatabaseExists(databaseName); // Create the Db if it doesn't exist
            using (IDocumentSession session = documentStore.OpenSession(databaseName))
            {
                foreach (var temp in lstObjs) { session.Store(temp); }
                session.SaveChanges();
            }          

        }


        public List<T> LoadAll(string databaseName)
        {
            var documentStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            documentStore.Initialize();
            using (IDocumentSession session = documentStore.OpenSession(databaseName))
            {
               return session.Query<T>().ToList();                             
            }
        }

       
        public T Load(string Id,string databaseName)
        {
            var documentStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            documentStore.Initialize();
            using (IDocumentSession session = documentStore.OpenSession(databaseName))
            {
                return session.Load<T>(Id);
            }
        }


    }
}
