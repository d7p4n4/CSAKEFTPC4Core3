using CSAKEFTPC4Core3.Class;
using CSARMetaPlan.Class;
using CSEFTPC4Core3Objects.Ac4yObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using static CSAKEFTPC4Core3.Class.GrandPa;

namespace CSAKEFTPC4Core3
{
    public class Context : DbContext
    {
        private IConfiguration Configuration;

        public Context() : base()
        {

            Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyConnection"));

        }
        /*
        public DbSet<Kepernyo> Keprnyos { get; set; }
        public DbSet<AdatElem> AdatElems { get; set; }
        public DbSet<Programkod> Programkods { get; set; }
        public DbSet<Tabla> Tablas { get; set; }
        public DbSet<Muvelet> Muvelets { get; set; }*/
        public DbSet<Ac4yPersistentChild> Ac4yPersistentChilds { get; set; }
        public DbSet<RAMetaObjektum> RAMetaObjektums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Kepernyo>().ToTable("Keprnyos");
            //modelBuilder.Entity<AdatElem>().ToTable("AdatElems");
            modelBuilder.Entity<Programkod>().ToTable("Programkods");
            //modelBuilder.Entity<Tabla>().ToTable("Tablas");
            //modelBuilder.Entity<Muvelet>().ToTable("Muvelets");

            modelBuilder.Entity<Ac4yPersistentChild>().ToTable("Ac4yPersistentChilds");
            //modelBuilder.Entity<RAMetaObjektum>().ToTable("RAMetaObjektums");


            //modelBuilder.Entity<Ac4yPersistentChild>().HasNoKey();
        }

    }
}
