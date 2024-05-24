using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IRepository<T> Repository { get; }
        void Commit();
    }
}
