using System;
using System.Xml.Linq;

namespace LINQtoXML
{
    class XML_ex
    {
        public static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("Z:\\Dot.net\\ASSIGNMENTS_MAIN\\LINQ_XML\\example.xml");

            // Query the XML using LINQ
            var people = from person in doc.Descendants("person")
                         select new
                         {
                             Name = person.Element("name").Value,
                             Age = person.Element("age").Value
                         };

            // Iterate over the results and print them
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}




