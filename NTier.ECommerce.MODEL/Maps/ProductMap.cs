using NTier.ECommerce.CORE.Map;
using NTier.ECommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Maps
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            HasRequired(x => x.SubCategory).WithMany(x => x.Products).HasForeignKey(x => x.SubCategoryID);
        }
    }
}
