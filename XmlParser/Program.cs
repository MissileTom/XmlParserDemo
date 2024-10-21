// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

var path = "/Users/TomBarrett/Downloads/sdn_enhanced.xml";

var serializer = new XmlSerializer(typeof(SanctionsData));
using (var reader = new StreamReader(path)) 
{ 
    var data = (SanctionsData)serializer.Deserialize(reader);
    if (data is not null)
    {
        Console.WriteLine($"found {data.Entities.Count} entities");
    }
}