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
    
    public partial class USER
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Nullable<long> PhoneNumber { get; set; }
        public Nullable<byte> RoleId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}