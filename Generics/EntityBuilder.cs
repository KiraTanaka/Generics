using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class EntityBuilder<TEngine>
    {
        public LoggerBuilder<TEngine,TEntity> For<TEntity>()
        {
            return new LoggerBuilder<TEngine, TEntity>();
        }
    }
}
