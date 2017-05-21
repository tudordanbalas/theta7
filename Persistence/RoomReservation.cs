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
    
    public partial class RoomReservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomReservation()
        {
            this.PaperReservations = new HashSet<PaperReservation>();
        }
    
        public int RoomReservationId { get; set; }
        public int SessionId { get; set; }
        public int RoomId { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual AvailableRoom AvailableRoom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaperReservation> PaperReservations { get; set; }
        public virtual Session Session { get; set; }
    }
}
