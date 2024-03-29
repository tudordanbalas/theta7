//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class AvailableRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AvailableRoom()
        {
            this.RoomReservations = new HashSet<RoomReservation>();
        }
    
        public int RoomId { get; set; }
        public int ConferenceId { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public int AddressId { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Conference Conference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomReservation> RoomReservations { get; set; }
    }
}
