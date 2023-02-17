using System.IO;
using System.Xml.Serialization;

namespace desing_patterns_csharp_2.Cap8
{
    class GeradorDeXml
    {
        public string GeraXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
