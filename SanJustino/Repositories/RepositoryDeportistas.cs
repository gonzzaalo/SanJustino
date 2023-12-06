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
    public class RepositoryDeportistas
    {
        public IEnumerable<Deportista> GetAll()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportistas.Include(s => s.Localidad.Provincia).ToList();
        }

        public IEnumerable<Deportista>GetAll(string textoBusqueda)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportistas.Where(c => c.Nombre.Contains(textoBusqueda.Trim()) || c.Apellido.Contains(textoBusqueda.Trim())).Include(s => s.Localidad.Provincia).ToList();
        }

        public Deportista? GetById(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Deportistas.Find(id);
        }

        public void Remove(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            Deportista? deportista = context.Deportistas.Find(id);
            if(deportista != null)
            {
                context.Deportistas.Remove(deportista);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"El deportista con el id {id} no se encontró en la base de datos, no pudo eliminarse");
            }
        }

        public void Add(Deportista deportista)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Deportistas.Add(deportista);
            context.SaveChanges();
        }

        public void Update(Deportista deportista)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Entry(deportista).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
