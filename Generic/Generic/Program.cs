using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
        
    public class ProcessorBilder
    {
        public static SecondProcessorBilder<TEngine> CreateEngine<TEngine>()
        {
            return new SecondProcessorBilder<TEngine>();
        }
    }

    public class SecondProcessorBilder<TEngine>
    {
        public ThirdProcessorBilder<TEngine, TEntity> For<TEntity>()
        {
            return new ThirdProcessorBilder<TEngine, TEntity>();
        }
    }
    public class ThirdProcessorBilder<TEngine, TEntity>
    {
        public Processor<TEngine, TEntity, TLogger> With<TLogger>()
        {
            return new Processor <TEngine, TEntity, TLogger>();
        }
    }
    public class Processor<TEngine, TEntity, TLogger>
    {
    
    }
   
    class Program
    {
        static void Main(string[] args)
        {             
            var p = ProcessorBilder.CreateEngine<int>().For<int>().With<int>();
            Console.ReadKey(true);
        }
    }
}
