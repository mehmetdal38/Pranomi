using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pranomi.ViewModels.Product
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required][StringLength(200,ErrorMessage ="Maximum 200 karakter")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsVirtual { get; set; }
        [Required]
        public decimal Stock { get; set; }
        public string PictureUrl { get; set; }
        public bool IsActive { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public int CurrencyID { get; set; }
        public decimal PurPriceExVat { get; set; }
        public decimal PurPriceInVat { get; set; }
        public decimal SalPriceExVat { get; set; }
        public decimal SalPriceInVat { get; set; }
    }
}
