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
    
    public partial class CreditCardPay
    {
        public int ID { get; set; }
        public int Kind { get; set; }
        public int TotalInstallment { get; set; }
        public int CurrentInstallment { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Date { get; set; }
        public int DocumentID { get; set; }
    }
}
