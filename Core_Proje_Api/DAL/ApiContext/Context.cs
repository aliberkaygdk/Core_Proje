﻿using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ALI;database=CoreProjeDB2;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
