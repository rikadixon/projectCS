using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
   public class RepositoryID
    {
        private Dictionary<Guid, Object> objectData;
        private Dictionary<Type, List<Guid>> guidObjectData;
        public T CreateObj<T>(T objectFromUser)
            where T: new()
        {
            T newObject = objectFromUser;
            Guid myguidData = Guid.NewGuid();

            objectData.Add(myguidData, newObject);

            if (guidObjectData.ContainsKey(newObject.GetType()))
            {
                guidObjectData[newObject.GetType()].Add(myguidData);
            }
            else
            {
                var list = new List<Guid>();
                list.Add(myguidData);

                guidObjectData.Add(newObject.GetType(), list);
            }
            
            return newObject;
        }
        public Dictionary<Guid, T> OutputsGuidAndObj <T>()
            where T: new()
        {
            var list = guidObjectData[(new T()).GetType()];

            var result = new Dictionary<Guid, T>();

            foreach (Guid guid in list)
            {
                result.Add(guid, (T)objectData[guid]);
            }

            return result;
        }
        public object OutputsObjByGuid(Guid guidData) {
            object value;
            if (objectData.TryGetValue(guidData,out value))
            {
                return value;
            }
            else {
                return null;
            }
        }
    }
}
