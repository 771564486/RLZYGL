using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentModel
    {
        private int stuId;

        public int StuId
        {
            get { return stuId; }
            set { stuId = value; }
        }
        private string stuName;

        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }
    }
}
