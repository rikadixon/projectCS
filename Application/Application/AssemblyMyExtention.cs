using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Application
{
    public static class AssemblyMyExtention
    {
        public static List<Type> GetTypesInterface(this Assembly assembly, Type interfaceType)
        {
            return assembly.GetTypes().ToList().FindAll(type => type.GetInterfaces().Contains(interfaceType));
        }
    }
}
