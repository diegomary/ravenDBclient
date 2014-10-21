using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Extensions;
using RavenHQClient.Model;
using System;
using System.Collections.Generic;
using RavenHQClient.Repository;
using System.Linq;

namespace RavenHQClient
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<BlogPost> lst = new List<BlogPost>();
            for (int i = 0; i < 10; i++)
            {
                BlogPost post = new BlogPost()
                {
                    Id = i.ToString(),
                    Title = "Hello RavenDB",
                    Category = "RavenDB",
                    Content = "This is a blog about RavenDB",
                    Comments = new BlogComment[]
                                    {
                                        new BlogComment() {Title = "Unrealistic", Content = "This example is unrealistic"},
                                        new BlogComment() {Title = "Nice", Content = "This example is nice"} 
                                    }
                };
                lst.Add(post);
            }



            IRepository<BlogPost> iRepo = new Repository<BlogPost>();
            iRepo.Store(lst,"DiegoDB");



            List<BlogPost> lst1 = iRepo.LoadAll("DiegoDB");
            BlogPost ggg = iRepo.Load("5", "DiegoDB");
          
          
           
        }
    }
}
