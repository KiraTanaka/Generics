using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class RepositoryID
    {
        Dictionary<Type, Dictionary<Guid, Object>> Database = new Dictionary<Type, Dictionary<Guid, Object>>();
        TObject CreateObject<TObject>() where TObject : new()
        {
            if (!Database.ContainsKey(typeof(TObject)))
                Database.Add(typeof(TObject),new Dictionary<Guid, object>());
            TObject newObject = new TObject();
            Database[typeof(TObject)].Add(Guid.NewGuid(), newObject);
            return newObject;
        }
        Dictionary<Guid, Object> GetGuidObjectPair<TObject>()
        {
            return Database[typeof(TObject)];
        }
        TObject GetObjectOrDefaultByGuid<TObject>(Guid guid)
        {
            return Database[typeof(TObject)].ContainsKey(guid) ? (TObject)Database[typeof(TObject)][guid] : default(TObject);
        }
    }
}
