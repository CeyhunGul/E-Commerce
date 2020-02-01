using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Entity
{
    public class Category:CoreEntity
    {
       
        public string Description { get; set; }
        public string ImagePath { get; set; }

        //bir kategorinin birden fazla altkategorisi olur.
        public virtual List<SubCategory> SubCategories { get; set; }


    }
}
