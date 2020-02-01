using NTier.ECommerce.CORE.Map;
using NTier.ECommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Maps
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            HasMany(x => x.SubCategories)
                .WithRequired(x => x.Category).HasForeignKey(x => x.CategoryID);
        }
    }
}
