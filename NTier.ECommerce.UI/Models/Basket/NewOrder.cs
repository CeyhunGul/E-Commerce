using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTier.ECommerce.UI.Models.Basket
{
    public class NewOrder
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<SelectedProduct> SelectedProducts { get; set; }

    }
}