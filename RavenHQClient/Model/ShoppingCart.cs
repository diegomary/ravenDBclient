﻿using RavenHQClient.media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenHQClient.Model
{  
    public partial class ShoppingCartModel
    {
        public string Id { get; set;}
        public decimal GrandTotal { get { return Items.Sum(x => x.SubTotal); } }        
        public IList<ShoppingCartItemModel> Items { get; set; }
        public ShoppingCartCustomer Customer { get; set; }
        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }       

        public partial class ShoppingCartItemModel 
        {
            public ShoppingCartItemModel()
            {
                Picture = new PictureModel();
            }
            public string Id { get; set; }
            public string Sku { get; set; }            
            public PictureModel Picture { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }            
            public decimal UnitPrice { get; set; }
            public decimal SubTotal { get; set; }
            public decimal Discount { get; set; }
            public int Quantity { get; set; }
        }
       
    }
}
