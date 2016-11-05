using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Application
{
    public static class DirectoryMyInfoExtention
    {
        public static List<FileInfo> GetAllDllFiles(this DirectoryInfo directory)
        {
            var result = new List<FileInfo>();

            DirectoryInfo[] directories = directory.GetDirectories();

            FileInfo[] dllFiles = directory.GetFiles("*.dll");

            result.AddRange(dllFiles);

            foreach (var directoryInfo in directories)
            {
                result.AddRange(directoryInfo.GetAllDllFiles());
            }

            return result;
        }

        public static List<FileInfo> GetUniqueDllFiles(this DirectoryInfo directory)
        {
            var result = new List<FileInfo>();

            var dllFiles = directory.GetAllDllFiles();

            foreach (var dllFile in dllFiles)
            {
                var fileName = dllFile.Name;

                List<string> filesName = result.Select(file => file.Name).ToList();

                if (!filesName.Contains(fileName))
                {
                    result.Add(dllFile);
                }
            }

            return result;
        }
    }
    public static class AssemblyMyExtention
    {
        public static List<Type> GetTypesInterface(this Assembly assembly, Type interfaceType)
        {
            return assembly.GetTypes().ToList().FindAll(type => type.GetInterfaces().Contains(interfaceType));
        }
    }
}
