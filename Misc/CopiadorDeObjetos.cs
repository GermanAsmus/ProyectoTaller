using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Misc
{
    public static class CopiadorDeObjetos
    {
        public static T Clone<T>(T pObjeto)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("El tipo debe ser serializable");
            }
            //No serializar un objeto nulo, devolver el valor predeterminado para ese objeto.
            if (object.ReferenceEquals(pObjeto, null))
            {
                return default(T);
            }
            IFormatter formateador = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formateador.Serialize(stream, pObjeto);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formateador.Deserialize(stream);
            }
        }
    }
}