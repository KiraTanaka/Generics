using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    struct ST2<T> where T:Type
    {
        public T type;
    }
    
    class ProcessorBuilder
    {
        Type type;
        List<Type> array = new List<Type>();
        public ProcessorBuilder CreateEngine<TEngine>() where TEngine:new()
        {
            //array.Add(new TEngine());
            return this;
        }
        public ProcessorBuilder For<TEntity>() where TEntity : new()
        {
           // array.Add(new TEntity());
            return this;
        }
        public void With<TLogger>() where TLogger : new()
        {
           // Type p = typeof(TLogger);ST2<Type>
            //return new Processor<ST2<p>., , TLogger >();
        }
    }
}
