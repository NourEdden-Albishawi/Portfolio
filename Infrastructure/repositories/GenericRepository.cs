using Core.entities;
using Core.interfaces;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Core.repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext context;
        private DbSet<T> table;
        public GenericRepository(DataContext context) {

            this.context = context;
            table = this.context.Set<T>();
        }

        public void Delete(int id)
        {
            T existing = Get(id);
            table.Remove(existing); 
        }

        public T Get(object id)
        {
           return table.Find(id);
        }

        public IEnumerable<T> GetAll()
        { 
            return table.ToList();
        }

        public void Insert(T item)
        {
            table.Add(item);
        }

        public void Update(T item)
        {
            table.Attach(item);
            this.context.Entry(item).State = EntityState.Modified;
        }
    }
}
