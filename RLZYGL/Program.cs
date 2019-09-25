using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLZYGL
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBLL stuBLL = new StudentBLL();
            StudentModel stu = new StudentModel()
            {
                StuId=1
            };
            Console.WriteLine(stuBLL.SelectAll()[0].StuName);
            Console.ReadKey();
        }
    }
}
