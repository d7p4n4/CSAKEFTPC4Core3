﻿// <auto-generated />
using System;
using CSAKEFTPC4Core3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSAKEFTPC4Core3.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200605103819_migration.1.20200605.11")]
    partial class migration12020060511
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSAKEFTPC4Core3.Class.RAMetaObjektum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leiras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Megnevezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nevter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublikusKod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RAMetaObjektums");
                });

            modelBuilder.Entity("CSARMetaPlan.Class.Programkod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Forrasszoveg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Programkods");
                });

            modelBuilder.Entity("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentificationBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("humanId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publicHumanId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ac4yIdentificationBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Ac4yIdentificationBase");
                });

            modelBuilder.Entity("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yPersistentChild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Ac4yIdentificationId")
                        .HasColumnType("int");

                    b.Property<string>("GUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ages")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Ac4yIdentificationId");

                    b.ToTable("Ac4yPersistentChilds");
                });

            modelBuilder.Entity("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentification", b =>
                {
                    b.HasBaseType("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentificationBase");

                    b.Property<int?>("ac4yIdentificationBaseId")
                        .HasColumnType("int");

                    b.HasIndex("ac4yIdentificationBaseId");

                    b.HasDiscriminator().HasValue("Ac4yIdentification");
                });

            modelBuilder.Entity("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yPersistentChild", b =>
                {
                    b.HasOne("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentification", "Ac4yIdentification")
                        .WithMany()
                        .HasForeignKey("Ac4yIdentificationId");
                });

            modelBuilder.Entity("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentification", b =>
                {
                    b.HasOne("CSEFTPC4Core3Objects.Ac4yObjects.Ac4yIdentificationBase", "ac4yIdentificationBase")
                        .WithMany()
                        .HasForeignKey("ac4yIdentificationBaseId");
                });
#pragma warning restore 612, 618
        }
    }
}
