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
    public enum Role
    {
        none,
        member,
        admin
    }
    public class AppUser:CoreEntity
    {
        public AppUser()
        {
            IsActive = false;
        }
        [Required(ErrorMessage ="Lütfen adınızı yazın")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınızı 3-50 karakter arasında girebilirsiniz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı yazın")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Soydınızı 3-50 karakter arasında girebilirsiniz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen şifre yazın")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail adresinizi yazın")]
        [EmailAddress(ErrorMessage = "E-Posta formatında giriş yapınız")]
        public string Email { get; set; }
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Adınızı 3-150 karakter arasında girebilirsiniz.")]
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public DateTime? BirthDate { get; set; }

        public Guid ActivationCode { get; set; }

        public bool IsActive { get; set; }

        public Role Role { get; set; }

        //her kullanıcının birden fazla siparişi olur.
        public List<Order> Orders { get; set; }


    }
}
