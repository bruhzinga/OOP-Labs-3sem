using LABA5;
using LABA14;
using System.Collections;
using System.Xml;

var testList = new ArrayList()
{
    12,
    "Serialization",
};
var Ser = new CustomSerializer<ArrayList>(testList, 3);
Ser.Serialize();
var testlist2 = (ArrayList)(Ser.Desirialize());
foreach (var item in testlist2)
{
    Console.WriteLine(item);
}

XmlDocument xmlDocument = new XmlDocument();
xmlDocument.Load("object.xml");
var xRoot = xmlDocument.DocumentElement;

var selectNodes = xRoot.SelectNodes("*");
foreach (object node in selectNodes) Console.WriteLine((node as XmlNode).Name);

Console.WriteLine();
var nameNodes = xRoot.SelectNodes("Name");
foreach (object nameNode in nameNodes) Console.WriteLine((nameNode as XmlNode).InnerText);