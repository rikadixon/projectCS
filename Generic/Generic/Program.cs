using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
        
    public class Processor
    {
        public static Processor<TEngine> CreateEngine<TEngine>()
        {
            return new Processor<TEngine>();
        }
    }

    public class Processor<TEngine>
    {
        public Processor<TEngine, TEntity> For<TEntity>()
        {
            return new Processor<TEngine, TEntity>();
        }
    }
    public class Processor<TEngine, TEntity>
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
            var p = Processor.CreateEngine<int>().For<int>().With<int>();
            Console.ReadKey(true);
        }
    }
}
