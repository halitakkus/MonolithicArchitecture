using KluCareer.Entities.Concrate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KluCareer.DataAccessLayer.Concrate.Contexts
{
    public class KluCareerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationBuiler = new ConfigurationBuilder();
         
        
            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            configurationBuiler.AddJsonFile(appSettingsPath);
            string connectionString = configurationBuiler.Build().GetConnectionString("default");

            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(connectionString, option => { 
            //yeni yapılandırlamalr geldiğinde buradan eklenebilir...
            });
        }
      
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<DevirDaim> DevirDaim { get; set; }
        public DbSet<DevirDaimDurum> DevirDaimDurum { get; set; }
        public DbSet<News> News { get; set; }
    }
}
