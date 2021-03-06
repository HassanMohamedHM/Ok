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
    
    public partial class TransactionHeader
    {
        public TransactionHeader()
        {
            this.PostedTransactions = new HashSet<PostedTransactions>();
            this.TransactionLines = new HashSet<TransactionLines>();
        }
    
        public long transCode { get; set; }
        public Nullable<System.DateTime> transDate { get; set; }
        public Nullable<int> JournalCode { get; set; }
        public string Discription { get; set; }
        public Nullable<int> UserCode { get; set; }
        public Nullable<bool> IsPosted { get; set; }
    
        public virtual JournalNames JournalNames { get; set; }
        public virtual ICollection<PostedTransactions> PostedTransactions { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransactionLines> TransactionLines { get; set; }
    }
}
