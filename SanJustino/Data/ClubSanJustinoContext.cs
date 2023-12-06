using Microsoft.EntityFrameworkCore;
using SanJustino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJustino.Data
{
    public class ClubSanJustinoContext : DbContext
    {
        public  DbSet<Deportista> Deportistas { get; set; }

        public DbSet<Deporte> Deportes { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public DbSet<Provincia> Provincias { get; set; }

        public ClubSanJustinoContext()
        {

        }

        public ClubSanJustinoContext(DbContextOptions<ClubSanJustinoContext> options): base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS ; User Id=sa ; Password=123 ; Database=ClubSanJustinoContext; MultipleActiveResultSets = true; Encrypt=False ";
            optionsBuilder.UseSqlServer(cadenaConexion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Creando datos semillas de Deportistas

            modelBuilder.Entity<Deportista>().HasData(
                new Deportista() { Id = 1, Nombre = "Gonzalo", Apellido = "Reynoso", Email = "gonza@gmail.com", Telefono = "3465088483", Direccion = "Formosa 2110" },
                new Deportista() { Id = 2, Nombre = "Milagros", Apellido = "Gonzalez", Email = "Mili@gmail.com", Telefono = "346578345783", Direccion = "Formosa 2110" }
                );

            //Datos semillas Deportes

            modelBuilder.Entity<Deporte>().HasData(
                new Deporte() { Id = 1, Nombre = "Futsal", Horarios = "Lunes a Viernes 21:00 hs" },
                    new Deporte() { Id = 2, Nombre = "Voley", Horarios = "Lunes a Viernes 20:00 hs" }
                    );

            //Datos semillas Profes

            modelBuilder.Entity<Profesor>().HasData(
                new Profesor() { Id = 1, Nombre = "Javier Hernandez" },
                new Profesor() { Id = 2, Nombre = "Leonardo Haup" });

            //Creando datos semillas de Localidades

            modelBuilder.Entity<Localidad>().HasData(
                new Localidad() { Id = 1, Nombre = "San Justo", CodigoPostal = "3040" },
                new Localidad() { Id = 2, Nombre = "Videla", CodigoPostal = "3045" }
                );

            //Creando datos semillas de Provincias

            modelBuilder.Entity<Provincia>().HasData(
                new Provincia() { Id = 1, Nombre = "Santa Fe" },
                new Provincia() { Id = 2, Nombre = "Córdoba" });
        }
    }
}
