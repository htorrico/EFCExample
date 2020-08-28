using EFCExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCExample.DataContext
{
    class AppDbContext : DbContext
    {
        //Ubicación de la base de datos
        string DbPath = string.Empty;

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }
        //Configurar Archivo
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Document> Documents { get; set; }




    }
}
