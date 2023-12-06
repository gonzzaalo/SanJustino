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
    public class RepositoryLocalidades
    {
        public IEnumerable<Localidad>GetAll()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Localidades.Include(c => c.Provincia).ToList();

        }

        public IEnumerable<Localidad>GetAll(string textoBusqueda)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Localidades.Where(c => c.Nombre.Contains(textoBusqueda.Trim())).Include(c => c.Provincia).ToList();
        }

        public Localidad? GetById(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Localidades.Find(id);
        }

        public void Remove(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            Localidad? localidad = context.Localidades.Find(id);
            if (localidad != null)
            {
                context.Localidades.Remove(localidad);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"La localidad con el id {id} no se encontró en la base de datos, y no pudo eliminarse");
            }
        }

        public void Add(Localidad localidad)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Localidades.Add(localidad);
            context.SaveChanges();
        }

        public void Update(Localidad localidad)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Entry(localidad).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
