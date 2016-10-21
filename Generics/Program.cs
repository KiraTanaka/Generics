using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public class MyEngine { }
        public class MyEntity { }
        public class MyLogger { }
        static void Main(string[] args)
        {
            Processor<MyEngine, MyEntity, MyLogger> p = new Processor<MyEngine, MyEntity, MyLogger>();
            // Processor<MyEngine,MyEntity,MyLogger> processor =
            // ProcessorBuilder.CreateEngine<p.GetType()>().For<MyEntity>().With<MyLogger>();
        }
    }
}
