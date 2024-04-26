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
    [Migration("20240426172031_MoreSeedData")]
    partial class MoreSeedData
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
                            Created = new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nuevo",
                            Value = "Nuevo"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Existente",
                            Value = "Existente"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 1",
                            Value = "test 1"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 2",
                            Value = "test 2"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 3",
                            Value = "test 3"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 4",
                            Value = "test 4"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 5",
                            Value = "test 5"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 6",
                            Value = "test 6"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 7",
                            Value = "test 7"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 8",
                            Value = "test 8"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 9",
                            Value = "test 9"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 10",
                            Value = "test 10"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 11",
                            Value = "test 11"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 12",
                            Value = "test 12"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 13",
                            Value = "test 13"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 14",
                            Value = "test 14"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 15",
                            Value = "test 15"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 16",
                            Value = "test 16"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 17",
                            Value = "test 17"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 18",
                            Value = "test 18"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 19",
                            Value = "test 19"
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 20",
                            Value = "test 20"
                        },
                        new
                        {
                            Id = 23,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 21",
                            Value = "test 21"
                        },
                        new
                        {
                            Id = 24,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 22",
                            Value = "test 22"
                        },
                        new
                        {
                            Id = 25,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 23",
                            Value = "test 23"
                        },
                        new
                        {
                            Id = 26,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 24",
                            Value = "test 24"
                        },
                        new
                        {
                            Id = 27,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 25",
                            Value = "test 25"
                        },
                        new
                        {
                            Id = 28,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 26",
                            Value = "test 26"
                        },
                        new
                        {
                            Id = 29,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 27",
                            Value = "test 27"
                        },
                        new
                        {
                            Id = 30,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 28",
                            Value = "test 28"
                        },
                        new
                        {
                            Id = 31,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 29",
                            Value = "test 29"
                        },
                        new
                        {
                            Id = 32,
                            Created = new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "test 30",
                            Value = "test 30"
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
