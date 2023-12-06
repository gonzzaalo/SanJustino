﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SanJustino.Data;

#nullable disable

namespace SanJustino.Migrations
{
    [DbContext(typeof(ClubSanJustinoContext))]
    [Migration("20231201171211_agregamosProvinciaADeportista")]
    partial class agregamosProvinciaADeportista
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SanJustino.Models.Deporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Horarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deportes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Horarios = "Lunes a Viernes 21:00 hs",
                            Nombre = "Futsal"
                        },
                        new
                        {
                            Id = 2,
                            Horarios = "Lunes a Viernes 20:00 hs",
                            Nombre = "Voley"
                        });
                });

            modelBuilder.Entity("SanJustino.Models.Deportista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Deportistas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Reynoso",
                            Direccion = "Formosa 2110",
                            Email = "gonza@gmail.com",
                            Nombre = "Gonzalo",
                            Telefono = "3465088483"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Gonzalez",
                            Direccion = "Formosa 2110",
                            Email = "Mili@gmail.com",
                            Nombre = "Milagros",
                            Telefono = "346578345783"
                        });
                });

            modelBuilder.Entity("SanJustino.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Localidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodigoPostal = "3040",
                            Nombre = "San Justo"
                        },
                        new
                        {
                            Id = 2,
                            CodigoPostal = "3045",
                            Nombre = "Videla"
                        });
                });

            modelBuilder.Entity("SanJustino.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Javier Hernandez"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Leonardo Haup"
                        });
                });

            modelBuilder.Entity("SanJustino.Models.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provincias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Santa Fe"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Córdoba"
                        });
                });

            modelBuilder.Entity("SanJustino.Models.Deportista", b =>
                {
                    b.HasOne("SanJustino.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId");

                    b.HasOne("SanJustino.Models.Provincia", "provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");

                    b.Navigation("Localidad");

                    b.Navigation("provincia");
                });

            modelBuilder.Entity("SanJustino.Models.Localidad", b =>
                {
                    b.HasOne("SanJustino.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");

                    b.Navigation("Provincia");
                });
#pragma warning restore 612, 618
        }
    }
}
