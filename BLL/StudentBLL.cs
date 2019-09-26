using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using EF;
using Model;
using DAO;
using IocContainer;
using System.Linq.Expressions;
using IDAO;
namespace BLL
{
    public class StudentBLL:IStudentBLL
    {
        StudentDAO Idao = IocCreate.CreateDAO<StudentDAO>("containerTwo", "StudentBLL");

        //IStudentDAO<StudentModel> Idao = new StudentDAO();
        public int Insert(StudentModel t)
        {
            return Idao.Insert(t);
        }

        public int Update(StudentModel t)
        {
            return Idao.Update(t);
        }

        public int Delete(StudentModel t)
        {
            return Idao.Delete(t);
        }

        public List<StudentModel> SelectAll()
        {
            return Idao.SelectAll();
        }

        public List<StudentModel> SelectOne(Expression<Func<StudentModel, bool>> where)
        {
            return Idao.SelectOne(where);
        }

        public List<StudentModel> SelectFenye<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int PageIndex, int PageSize, out int rows)
        {
            return Idao.SelectFenye(order, where, PageIndex, PageSize, out rows);
        }
    }
}
