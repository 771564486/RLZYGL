using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
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
            exf.ExeConfigFilename ="D:\\C#作业\\C#Y2\\DF1\\RLZYGL\\IocContainer\\Untity.config";
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
    }
}
