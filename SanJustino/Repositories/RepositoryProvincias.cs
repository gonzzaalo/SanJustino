using Microsoft.EntityFrameworkCore;
using SanJustino.Data;
using SanJustino.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJustino.Repositories
{
    public class RepositoryProvincias
    {
        public IEnumerable<Provincia> GetAll()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Provincias.ToList();
        }

        public IEnumerable<Provincia> GetAll(string textoBusqueda)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Provincias.Where(c => c.Nombre.Contains(textoBusqueda.Trim())).ToList();
        }

        public void Remove(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            Provincia? provincia = context.Provincias.Find(id);
            if (provincia != null)
            {
                context.Provincias.Remove(provincia);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"La provincia con el id {id} no se encontró en la base de datos");
            }
        }

        public Provincia? GetById(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Provincias.Find(id);
        }

        public void Add(Provincia provincia)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Provincias.Add(provincia);
            context.SaveChanges();
        }

        public void Update(Provincia provincia)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Entry(provincia).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
