//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeMeUpzz.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionDetail
    {
        public int TransactionId { get; set; }
        public int MakeupId { get; set; }
        public int Quantity { get; set; }
    
        public virtual Makeup Makeup { get; set; }
        public virtual TransactionHeader TransactionHeader { get; set; }
    }
}