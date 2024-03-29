﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diploma.Models;
using Microsoft.EntityFrameworkCore;

namespace Diploma.EF
{
    class DiplomaContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Decease> Deceases { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ReabilitationType> ReabilitationTypes { get; set; }
        public DbSet<SocialIntegration> SocialIntegrations { get; set; }
        public DbSet<DisabilityGroup> DisabilityGroups { get; set; }
        public DbSet<ProvidedService> ProvidedServices { get; set; }
        public DbSet<ReabilitationCourse> ReabilitationCourses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Theme> Themes { get; set; }


        public DiplomaContext()
        {
            var d = ConfigurationManager.AppSettings.Get("connection_database");
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // AppSettings are in App.config
            string  adress= ConfigurationManager.AppSettings.Get("connection_adress");
            string  user= ConfigurationManager.AppSettings.Get("connection_user");
            string  password= ConfigurationManager.AppSettings.Get("connection_password");
            string database = ConfigurationManager.AppSettings.Get("connection_database");
            optionsBuilder.UseMySql($"server={adress};user={user};password={password};database={database};",
                new MySqlServerVersion(new Version(8, 0, 11))
                 
            );
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasOne(s => s.ReabilitationType).WithMany(p => p.Service).HasForeignKey(s => s.ReabilitationTypeId);

            //Used to get Enum from database and convert them to EF model
            modelBuilder.Entity<Patient>().Property(p => p.Sex).HasConversion(
                v => v.ToString(),
            v => (Sex)Enum.Parse(typeof(Sex), v));

            modelBuilder.Entity<Patient>().Ignore(p => p.FIO);      
        }

    }
}
