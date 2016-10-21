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
            ProcessorBuilder ProcessorBuilder = new ProcessorBuilder();
            Processor<MyEngine,MyEntity,MyLogger> processor =ProcessorBuilder.CreateEngine<MyEngine>().For<MyEntity>().With<MyLogger>();
        }
    }
}
