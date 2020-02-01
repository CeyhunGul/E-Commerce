using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.MODEL.Entity
{
    public class Product:CoreEntity
    {
        [Required(ErrorMessage ="Fiyat boş geçilemez!")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Stok boş geçilemez!")]
        public short? UnitsInStock { get; set; }
       
        public string ImagePath { get; set; }

        public Guid SubCategoryID { get; set; }

        //bir ürünün bir altkategorisi olur.
        public virtual SubCategory SubCategory { get; set; }

        //bir ürünün birden fazla sipariş detayı olur.
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
