using System.IO;
using System.Xml.Serialization;

namespace Elemental
{
    internal class MyStorage
    {
        public static void WriteXml<T>(T data, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            FileStream stream;
            stream = new FileStream(file, FileMode.Create);

            serializer.Serialize(stream, data);
            stream.Close();
        }

        //throw new NotImplementedException();


        public static T ReadXml<T>(string file)
        {

            using (StreamReader sr = new StreamReader(file))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                return (T)xmlSer.Deserialize(sr);
            }

        }
    }
}




