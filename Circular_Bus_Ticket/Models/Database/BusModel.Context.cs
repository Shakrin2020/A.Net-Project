﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circular_Bus_Ticket.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CircularBusEntities : DbContext
    {
        public CircularBusEntities()
            : base("name=CircularBusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BusInfo> BusInfoes { get; set; }
        public virtual DbSet<BusOwner> BusOwners { get; set; }
        public virtual DbSet<BusRoute> BusRoutes { get; set; }
        public virtual DbSet<SoldTicket> SoldTickets { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
