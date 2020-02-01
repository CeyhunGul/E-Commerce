using NTier.ECommerce.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.CORE.Service
{
    public interface ICoreService<T> where T:CoreEntity //BLL
    {
        void Add(T item);
        void Add(List<T> items);

        void Update(T item);

        void Remove(T item);

        void Remove(Guid id);

        //(x=>x.createddate==datetime.now)
        void RemoveAll(Expression<Func<T, bool>> exp);

        T GetById(Guid id);

        List<T> GetDefault(Expression<Func<T, bool>> exp);

        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();

        List<T> GetActive();

        bool Any(Expression<Func<T, bool>> exp);

        int Save();




    }
}
