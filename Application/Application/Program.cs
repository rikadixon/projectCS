using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Framework;
using System.IO;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryInfo = new DirectoryInfo("C:\\git-project\\Application");

            var dllFiles = directoryInfo.GetUniqueDllFiles();

            var frameworkDllFile = dllFiles.Find(file => file.Name == "Framework.dll");

            dllFiles.Remove(frameworkDllFile);

            List<Type> typesOfPlugins =
            dllFiles.SelectMany(
           file => Assembly.LoadFrom(file.FullName).GetTypesInterface(typeof(IPlugin))).ToList();

             if (typesOfPlugins.Select(type  => (IPlugin)type.GetConstructor(Type.EmptyTypes)) != null) {
                List<IPlugin> plugins =
                typesOfPlugins.Select(type => (IPlugin)Activator.CreateInstance(type)).ToList();
                plugins.ForEach(plugin => Console.WriteLine(plugin.PluginName));
            }
            Console.ReadKey(true);
        }
    }
}
