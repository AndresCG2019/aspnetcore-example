﻿// <auto-generated />
using System;
using Empresa.Proyecto.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    [DbContext(typeof(MyProjectContext))]
    [Migration("20240425233826_RelacionesNewEntity")]
    partial class RelacionesNewEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("CatalogExampleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogExampleId");

                    b.ToTable("ComplexEntity");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.NewEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdOpcion")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdOpcion");

                    b.ToTable("NewEntity");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.SimpleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SimpleEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nuevo",
                            Value = "Nuevo"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Existente",
                            Value = "Existente"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Reconstruido",
                            Value = "Reconstruido"
                        });
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.HasOne("Empresa.Proyecto.Core.Entities.SimpleEntity", "CatalogExample")
                        .WithMany()
                        .HasForeignKey("CatalogExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogExample");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.NewEntity", b =>
                {
                    b.HasOne("Empresa.Proyecto.Core.Entities.SimpleEntity", "Opcion")
                        .WithMany("NewEntities")
                        .HasForeignKey("IdOpcion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opcion");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.SimpleEntity", b =>
                {
                    b.Navigation("NewEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
