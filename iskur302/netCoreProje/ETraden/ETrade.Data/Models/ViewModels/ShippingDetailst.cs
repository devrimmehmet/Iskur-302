using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Models.ViewModels
{
    public class ShippingDetailst
    {
        [Required(ErrorMessage = "Lütfen Name Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="LÜtfen Bir Adres Giriniz")]
        public string AddressTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Mahalle { get; set; }
        public string PostalCode { get; set; }
    }
}
