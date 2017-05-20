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
    
    public partial class User
    {
        private int idUser;
        private string affiliation;
        private string website;
        private bool isSpecial;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ConferenceParticipants = new HashSet<ConferenceParticipant>();
            this.Papers = new HashSet<Paper>();
            this.PCMembers = new HashSet<PCMember>();
        }

        public User(int idUser, string username, string name, string password, string email, string affiliation, string website, bool isSpecial)
        {
            this.idUser = idUser;
            Username = username;
            Name = name;
            Password = password;
            Email = email;
            this.affiliation = affiliation;
            this.website = website;
            this.isSpecial = isSpecial;
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Affilliation { get; set; }
        public string WebPage { get; set; }
        public bool canBePCMember { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConferenceParticipant> ConferenceParticipants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paper> Papers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PCMember> PCMembers { get; set; }
    }
}