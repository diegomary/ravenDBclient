using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Extensions;
using RavenHQClient.Model;
using System;
using System.Collections.Generic;
using RavenHQClient.Repository;
using System.Linq;
using RavenHQClient.media;

namespace RavenHQClient
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCartModel myCart = new ShoppingCartModel();
            ShoppingCartModel.ShoppingCartItemModel firstItem = new ShoppingCartModel.ShoppingCartItemModel();
            firstItem.Picture = new PictureModel { ImageUrl = "http://www.dmm888.com/imageitem.jpg", Title = "The image of the Item", AlternateText = "None", FullSizeImageUrl = "http://www.dmm888.com/imageitemfullsize.jpg" };
            firstItem.ProductId = 1345;
            firstItem.ProductName = "Laptop of great power and speed";
            firstItem.Quantity = 4;
            firstItem.UnitPrice = 1290.45M;
            firstItem.SubTotal = firstItem.Quantity * firstItem.UnitPrice;
            firstItem.Sku = "R0UIT123";
            firstItem.Id = firstItem.Sku;

            myCart.Items.Add(firstItem);


            IRepository<ShoppingCartModel> iRepo = new Repository<ShoppingCartModel>();
            iRepo.Store(myCart, "DiegoDB");



            //List<ShoppingCartModel> lst1 = iRepo.LoadAll("DiegoDB");
            //BlogPost ggg = iRepo.Load("5", "DiegoDB");
          
          
           
        }
    }
}
