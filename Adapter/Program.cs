namespace Adapter
{
    // The Client Code
    internal class Program
    {
        static void Main(string[] args)
        {
            String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

            //Old Code Using XML Parser
            //IXmlParser<Note> xmlParser = new XmlParser<Note>();
            //Note xmlNote = xmlParser.Parse(someXml);
            //Console.WriteLine(xmlParser.ConvertToXml(xmlNote));

            //New Code Using Adapter to use JSON Parser
            IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
            Note note = parser.Parse(someXml);
            Console.WriteLine(parser.ConvertToJson(note));
        }
    }
}
