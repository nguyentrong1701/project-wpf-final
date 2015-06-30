//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unilever.DTO.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.FixedRegisters = new HashSet<FixedRegister>();
            this.Sales = new HashSet<Sale>();
            this.Stocks = new HashSet<Stock>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.GeneralSales = new HashSet<GeneralSale>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Description { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> CatId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<FixedRegister> FixedRegisters { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<GeneralSale> GeneralSales { get; set; }
    }
}
