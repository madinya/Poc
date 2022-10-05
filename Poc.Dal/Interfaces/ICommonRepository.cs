using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Dal.Interfaces
{
    public interface ICommonRepository<T>
    {
        List<T> GetAll();

        T Get(int id);

        void Insert(T item);

        void Update(T item);

        void Delete(T item);

        int SaveChanges();
    }
}