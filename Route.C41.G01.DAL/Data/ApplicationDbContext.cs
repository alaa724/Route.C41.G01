﻿using Microsoft.EntityFrameworkCore;
using Route.C41.G01.DAL.Data.Configurations;
using Route.C41.G01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G01.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options )
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("Server = .; Database = MVCAplicationG01; Trusted_Connection = True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Department> Departments { get; set; }
    }
}
