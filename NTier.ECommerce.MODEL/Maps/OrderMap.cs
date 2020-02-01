using NTier.ECommerce.CORE.Map;
using NTier.ECommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Maps
{
    public class OrderMap:CoreMap<Order>
    {
        public OrderMap()
        {
            HasRequired(x => x.AppUser)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.AppUserID);
        }
    }
}
