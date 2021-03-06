//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pranomi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderLine()
        {
            this.OrderLineTaxes = new HashSet<OrderLineTaxes>();
        }
    
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Unit { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Products Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLineTaxes> OrderLineTaxes { get; set; }
    }
}
