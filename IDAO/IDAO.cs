using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IDAO<T> where T:class
    {
         int Insert(T t);
         int Update(T t);
         int Delete(T t);
         List<T> SelectAll();
         List<T> SelectOne(Expression<Func<T, bool>> where);
         List<T> SelectFenye<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int PageIndex, int PageSize, out int rows);
    }
}
