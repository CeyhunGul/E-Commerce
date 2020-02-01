using NTier.ECommerce.CORE.Map;
using NTier.ECommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Maps
{
    public class SubCategoryMap:CoreMap<SubCategory>
    {
        public SubCategoryMap()
        {
            HasMany(x => x.Products)
                .WithRequired(x => x.SubCategory)
                .HasForeignKey(x => x.SubCategoryID);
        }
    }
}
