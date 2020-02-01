using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Entity
{
    public class SubCategory:CoreEntity
    {
       
        public string Description { get; set; }

        //bir altketgorinin bir kategorisi olur.
        public Guid CategoryID { get; set; }
        public Category Category { get; set; }
        //bir alt kategorinin birden fazla ürünü olur.
        public virtual List<Product> Products { get; set; }

    }
}
