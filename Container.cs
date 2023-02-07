using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleTestApp
{
    public static class Container
    {
        public static IUnityContainer _unityContainer = new UnityContainer();

        static Container()
        {
            _unityContainer.RegisterType<IConvert, NumToRoman>();
        }
    }
}
