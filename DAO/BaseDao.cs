using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using EF;
using System.Data.SqlClient;
using System.Data.Entity;
namespace DAO
{
   public class BaseDao<T> where T: class
    {
       MyDbContext md = new MyDbContext();
       public int Insertbase(T t)
       {
           md.Set<T>().Add(t);
           return md.SaveChanges();
       }
       public int Updatebase(T t)
       {
           md.Set<T>().Attach(t);
           md.Entry<T>(t).State = EntityState.Modified;
           return md.SaveChanges();
       }
       public int Deletebase(T t)
       {
           md.Set<T>().Attach(t);
           md.Entry<T>(t).State = EntityState.Detached;
           return md.SaveChanges();
       }
       public List<T> SelectAllbase()
       {
           return md.Set<T>().AsNoTracking().Select(e=>e).ToList<T>();
       }
       public List<T> SelectOnebase(Expression<Func<T, bool>> where)
       {
           return md.Set<T>().AsNoTracking().Select(e => e).Where(where).ToList<T>();
       }
       public List<T> SelectFenyebase<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int PageIndex, int PageSize, out int rows)
       {
            var Result= md.Set<T>().Select(e => e).AsNoTracking().OrderBy(order);
            rows = Result.Count();
            return Result.Select(e => e).Where(where).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList<T>();
       }

    }
}
