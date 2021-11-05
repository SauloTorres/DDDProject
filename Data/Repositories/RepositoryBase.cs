using Data.Context;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        private readonly DDDProjectContext db = new DDDProjectContext();
        public void Add(T obj)
        {
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            db.Set<T>().Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
