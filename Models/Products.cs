using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace EbayMVC.Models
{
    public class Products
    {
        
        public string Id { get; set; }
        public string listing_url { get; set; }
        public string gallery_url { get; set; }
        public string item_title { get; set; }
        public string tblCategory { get; set; }
    }

    public class ProductsDBContext : DbContext
    {
        public DbSet<Products> Store { get; set; }
    }
}