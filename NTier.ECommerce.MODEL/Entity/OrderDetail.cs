using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Entity
{
    public class OrderDetail:CoreEntity
    {
       
        public short? Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal? Price { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
