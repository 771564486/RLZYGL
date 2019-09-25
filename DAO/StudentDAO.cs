  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using IDAO;
using Model;
using System.Linq.Expressions;
namespace DAO
{
    public class StudentDAO : BaseDao<Student>, IStudentDAO<StudentModel>
    {
        public int Insert(StudentModel t)
        {
            Student stu = new Student()
            {
                StuName = t.StuName
            };
            return Insertbase(stu);
        }

        public int Update(StudentModel t)
        {
            Student stu = new Student()
            {
                StuId = t.StuId,
                StuName = t.StuName
            };
            return Updatebase(stu);
        }

        public int Delete(StudentModel t)
        {
            Student stu = new Student()
            {
                StuId = t.StuId,
                StuName = t.StuName
            };
            return Deletebase(stu);
        }

        public new List<StudentModel> SelectAll()
        {
            var Result = SelectAllbase();
            List<StudentModel> list = new List<StudentModel>();
            foreach (var item in Result)
            {
                StudentModel stu = new StudentModel()
                {
                    StuId = item.StuId,
                    StuName = item.StuName
                };
                list.Add(stu);
            }
            return list;
        }
        public List<StudentModel> SelectOne(Expression<Func<StudentModel, bool>> where)
        {
            //var Result = SelectOnebase(where1);
            //List<StudentModel> list = new List<StudentModel>();
            //foreach (var item in Result)
            //{
            //    StudentModel stu = new StudentModel()
            //    {
            //        StuId = item.StuId,
            //        StuName = item.StuName
            //    };
            //    list.Add(stu);
            //}
            return null;
        }

        public List<StudentModel> SelectFenye<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int PageIndex, int PageSize, out int rows)
        {
            //var Result = SelectFenyebase(order, where, PageIndex, PageSize, out rows);
            //List<StudentModel> list = new List<StudentModel>();
            //foreach (var item in Result)
            //{
            //    StudentModel stu = new StudentModel()
            //    {
            //        StuId = item.StuId,
            //        StuName = item.StuName
            //    };
            //    list.Add(stu);
            //}
            rows = 0;
            return null;
        }
    }
}
