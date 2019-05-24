﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.DB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCustomerApp.Models;

namespace WebCustomerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
			Database.EnsureCreated();
		}

        public DbSet<Message> Messages { get; set; }
        public DbSet<PhoneRec> PhoneRecs { get; set; }
        public DbSet<UserMessage> UserMessages{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
