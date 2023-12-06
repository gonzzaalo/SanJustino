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
    public class RepositoryDeportes
    {
        public IEnumerable<Deporte> GetAll()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportes.Include(c => c.Profesor).ToList();
        }

        public IEnumerable<Deporte> GetAll(string textoBusqueda)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportes.Where(c => c.Nombre.Contains(textoBusqueda.Trim())).Include(c => c.Profesor).ToList();
        }

        public void Remove(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            Deporte? deporte = context.Deportes.Find(id);
            if (deporte != null)
            {
                context.Deportes.Remove(deporte);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"El deporte con el id {id}, no pudo ser encotrado en la base de datos y no pudo eliminarse");
            }
        }

        public Deporte? GetById(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportes.Find(id);
        }

        public void Add(Deporte deporte)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Deportes.Add(deporte);
            context.SaveChanges();
        }

        public void Update(Deporte deporte)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Entry(deporte).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
