//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int RentId { get; set; }
        public int Book_Id { get; set; }
        public int User_Id { get; set; }
        public System.DateTime Return_date { get; set; }
        public System.DateTime Rent_date { get; set; }
        public string Status { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
