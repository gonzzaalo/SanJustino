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
    public class RepositoryProfesores
    {
       public IEnumerable<Profesor>GetAll()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Profesores.ToList();
        }

        public Profesor? GetById(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            return context.Profesores.Find(id);
        }

        public void Remove(int id)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            Profesor? profesor = context.Profesores.Find(id);
            if (profesor != null)
            {
                context.Profesores.Remove(profesor);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"El profesor con el id {id} no se encontro en la base de datos, por lo tanto no pudo eliminarse");
            }
        }

        public void Add(Profesor profesor)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Profesores.Add(profesor);
            context.SaveChanges();
        }

        public void Update(Profesor profesor)
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            context.Entry(profesor).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
