﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookin1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Booking_AppEntities : DbContext
    {
        public Booking_AppEntities()
            : base("name=Booking_AppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Booking_Equipment> Booking_Equipment { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Equipment_Status> Equipment_Status { get; set; }
        public virtual DbSet<Meeting_Room> Meeting_Room { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Room_Status> Room_Status { get; set; }
        public virtual DbSet<Room_Type> Room_Type { get; set; }
        public virtual DbSet<Room_Usage_Log> Room_Usage_Log { get; set; }
        public virtual DbSet<signup> signup { get; set; }
    }
}
