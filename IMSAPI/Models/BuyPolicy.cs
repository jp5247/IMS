//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMSAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyPolicy
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PolicyId { get; set; }
        public Nullable<int> PolicyCategoryId { get; set; }
        public Nullable<double> AmountPaid { get; set; }
        public string RequiredDocument { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
