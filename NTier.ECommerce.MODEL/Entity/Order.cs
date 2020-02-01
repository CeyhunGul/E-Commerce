using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Entity
{
    public class Order:CoreEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public bool Confirmed { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
