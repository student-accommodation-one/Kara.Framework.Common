using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kara.Framework.Common.Helpers
{
    public  class SerializationHelper
    {
        public static string ToXml<T>(T instance) where T : class
        {
            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractSerializer(instance.GetType());
                serializer.WriteObject(ms, instance);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
