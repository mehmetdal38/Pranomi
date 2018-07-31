using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pranomi.ViewModels
{
    public class ProductListViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string PictureUrl { get; set; }
        public decimal Stock { get; set; }
        public bool IsActive { get; set; }
    }
}
