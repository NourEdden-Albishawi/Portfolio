using Core.interfaces;
using Core.repositories;
using Infrastructure;

namespace Portfolio.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext context;
        private IRepository<T> repository;
        public IRepository<T> Repository
        {
            get
            {
                return this.repository ??= new GenericRepository<T>(context);
            }
        }


        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
