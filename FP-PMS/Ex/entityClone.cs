using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FP_PMS.Ex
{
    public static class entityClone
    {
        public static T Clone<T>(this T source)
        {
            var dcs = new System.Runtime.Serialization.DataContractSerializer(typeof(T));
            using (var ms = new System.IO.MemoryStream())
            {
                dcs.WriteObject(ms, source);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                return (T)dcs.ReadObject(ms);
            }
        }

        public static bool IsNullOrDefault<T>(this T value)
        {
            return object.Equals(value, default(T));
        }

        public static void setProperty<T>(this T source, T copy)
        {
            Type t = source.GetType();
            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var prop = copy.GetType().GetProperty(property.Name);
                var value = prop.GetValue(copy, null);
                property.SetValue(source, value, null);
            }
        }
    }
}
