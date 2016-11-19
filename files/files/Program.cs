using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Dynamic;

namespace files
{
    public class Program
    {
        public static IEnumerable<string[]> ReadCsv1(string fileName)
        {
            using (var stream = new StreamReader(fileName))
            {
                string line;

                while ((line = stream.ReadLine()) != null)
                {
                    yield return line.Replace("\"", "")
                        .Split(',','.')
                        .Select(str => str == "NA" ? null : str)
                        .ToArray();
                }

                stream.Close();
            }
        }

        public static IEnumerable<T> ReadCsv2<T>(string fileName)
        {
            var lines = ReadCsv1(fileName);
            var fieldNames = lines.First();

            lines = lines.Skip(1);

            yield break;
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}