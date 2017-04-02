﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISS_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UsersContainer : DbContext
    {
        public UsersContainer()
            : base("name=UsersContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ConferenceParticipant> ConferenceParticipants { get; set; }
        public virtual DbSet<Paper> Papers { get; set; }
        public virtual DbSet<OrganizingComiteeMember> OrganizingComiteeMembers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<AdditionalAuthor> AdditionalAuthors { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<PaperTag> PaperTags { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomReservation> RoomReservations { get; set; }
        public virtual DbSet<PaperReservation> PaperReservations { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
    }
}
