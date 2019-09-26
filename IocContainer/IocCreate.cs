using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using IDAO;
using IBLL;
using Model;
using DAO;

namespace IocContainer
{
    public class IocCreate
    {
        public static T CreateDAO<T>(string a, string b)
        {
            UnityContainer ioc = CreatIoc(a);
            T ib = ioc.Resolve<T>(b);
            return ib;
        }

        public static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap exf = new ExeConfigurationFileMap();
            exf.ExeConfigFilename = @"D:\C#作业\C#Y2\DF1\RLZYGL\RLZYGL\Untity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(exf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cfs, name);
            return ioc;
        }

        public static T CreateBLL<T>(string yi, string er)
        {
            IUnityContainer ioc = CreatIoc(yi);
            T ib = ioc.Resolve<T>(er);
            return ib;
        }
        //public static IStudentDAO<StudentModel> CreateStudentDAO()
        //{
        //    UnityContainer ioc = new UnityContainer();
        //    ioc.RegisterType<IStudentDAO<StudentModel>,StudentDAO>();
        //    return ioc.Resolve<IStudentDAO<StudentModel>>();
        //}
        //public static IStudentBLL<StudentModel> CreateUserBLL()
        //{
        //    UnityContainer ioc = new UnityContainer();
        //    //把Unity文件转换为文件对象
        //    ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
        //    ef.ExeConfigFilename = @"D:\C#作业\C#Y2\DF1\RLZYGL\RLZYGL\Untity.config";
        //    //把文件对象转换为配置对象
        //    Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
        //    //读取Unity节点(业务逻辑层的块)
        //    UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
        //    //容器里加载业务逻辑层的配置块
        //    ioc.LoadConfiguration(cs, "containerTwo");
        //    //根据配置文件的name来定位对象
        //    return ioc.Resolve<IStudentBLL<StudentModel>>("StudentBLL");
        //}
    }
}
