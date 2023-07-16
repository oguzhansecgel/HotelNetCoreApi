﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3QG9GTV;initial catalog = HotelApiDB; integrated security=true");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Staff> Staffs{ get; set; }
        public DbSet<Subscriber> Subscribers{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }

    }
}