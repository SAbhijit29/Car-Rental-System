//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Rental
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Rental()
        {
            this.tbl_Car = new HashSet<tbl_Car>();
            this.tbl_Customer = new HashSet<tbl_Customer>();
        }
    
        public int RentalId { get; set; }
        public System.DateTime PickupDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public double FairAmount { get; set; }
        public string InitialFuel { get; set; }
        public int AdminId { get; set; }
    
        public virtual tbl_Admin tbl_Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Car> tbl_Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Customer> tbl_Customer { get; set; }
    }
}
