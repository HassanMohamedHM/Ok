//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unit
    {
        public Unit()
        {
            this.Product = new HashSet<Product>();
            this.Product1 = new HashSet<Product>();
            this.Product2 = new HashSet<Product>();
            this.ProductOnHand = new HashSet<ProductOnHand>();
            this.UOMConversions = new HashSet<UOMConversions>();
            this.UOMConversions1 = new HashSet<UOMConversions>();
        }
    
        public int Unit_Code { get; set; }
        public string Unit_Name { get; set; }
        public Nullable<int> CatCode { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Product> Product1 { get; set; }
        public virtual ICollection<Product> Product2 { get; set; }
        public virtual ICollection<ProductOnHand> ProductOnHand { get; set; }
        public virtual UOMCCategory UOMCCategory { get; set; }
        public virtual ICollection<UOMConversions> UOMConversions { get; set; }
        public virtual ICollection<UOMConversions> UOMConversions1 { get; set; }
    }
}