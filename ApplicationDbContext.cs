﻿using Microsoft.Extensions.Configuration;
using System.Data.Entity;

namespace Calendar
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Task>? Tasks { get; set; }

        public ApplicationDbContext() : base()
        {

        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  var builder = new ConfigurationBuilder()
        //      .AddJsonFile($"appsettings.json", true, true);

        //  var config = builder.Build();


        //}
    }
}