using System.Xml.Serialization;

namespace Adapter
{
    public class XmlParser<T> : IXmlParser<T>
    {
        private readonly XmlSerializer _serializer;

        public XmlParser()
        {
            _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(typeof(T).Name.ToLower()));
        }

        public T Parse(string data)
        {
            using TextReader reader = new StringReader(data);
            var result = _serializer.Deserialize(reader);
            if (result is null)
            {
                throw new InvalidOperationException("Deserialization resulted in a null object.");
            }
            return (T)result;
        }

        public string ConvertToXml(T obj)
        {
            using StringWriter textWriter = new();
            _serializer.Serialize(textWriter, obj);

            return textWriter.ToString();
        }
    }
}
