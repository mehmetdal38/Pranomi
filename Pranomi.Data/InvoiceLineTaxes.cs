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
    
    public partial class InvoiceLineTaxes
    {
        public int ID { get; set; }
        public int TaxesID { get; set; }
        public int InvoiceLineID { get; set; }
        public decimal Value { get; set; }
    
        public virtual InvoiceLine InvoiceLine { get; set; }
        public virtual Taxes Taxes { get; set; }
    }
}
