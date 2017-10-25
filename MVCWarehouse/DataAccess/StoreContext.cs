using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWarehouse.DataAccess
{
    public class StoreContext : DbContext
    {
        public void DefaultConnection()
        {

        }

        public DbSet<Models.StockItem> Items { get; set; }
    }
}