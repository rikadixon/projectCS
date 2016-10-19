using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
   public class RepositoryID
    {
        public Dictionary<Guid, Object> obj { get; private set; }
        public Dictionary<Type, List<Guid>> guidObjData { get; private set; }
        public T CreateObj<T>(T obj)
            where T: new()
        {
            T newObj = new T();
            newObj = obj;
            Guid myguidData = Guid.NewGuid();

            this.obj.Add(myguidData, newObj);

            if (guidObjData.ContainsKey(newObj.GetType()))
            {
                guidObjData[newObj.GetType()].Add(myguidData);
            } else
            {
                var list = new List<Guid>();
                list.Add(myguidData);

                guidObjData.Add(newObj.GetType(), list);
            }
            
            return newObj;
        }
        public Dictionary<Guid, T> OutputsGuidAndObj <T>()
            where T: new()
        {
            var list = guidObjData[(new T()).GetType()];

            var result = new Dictionary<Guid, T>();

            foreach (Guid guid in list)
            {
                result.Add(guid, (T)obj[guid]);
            }

            return result;
        }
        public object OutputsObjByGuid(Guid guidData) {
            if (obj.ContainsKey(guidData))
            {
                return obj[guidData];
            }
            else {
                return null;
            }
        }
    }
}
