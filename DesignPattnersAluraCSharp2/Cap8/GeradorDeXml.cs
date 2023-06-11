using System.Xml.Serialization;

namespace DesignPattnersAluraCSharp2.Cap8
{
    public class GeradorDeXml
    {
        public String GeraXml(Object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}
