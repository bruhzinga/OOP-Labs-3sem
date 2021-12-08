using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using LABA5;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LABA14
{
    internal class CustomSerializer<T>
    {
        public object subject;

        public int type;

        public CustomSerializer(object subject, int type)

        {
            this.subject = subject;
            this.type = type;
        }

        public void Serialize()
        {
            switch (type)
            {
                case 1:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream("object.dat", FileMode.Create))
                    {
                        formatter.Serialize(fs, subject);
                    }
                    break;

                case 2:
                    {
                        SoapFormatter soapFormatter = new SoapFormatter();
                        using (Stream fStream = new FileStream("object.dat", FileMode.Create))

                        {
                            soapFormatter.Serialize(fStream, subject);
                        }
                        break;
                    }
                case 3:
                    {
                        XmlSerializer xSer = new XmlSerializer(typeof(T));
                        using (FileStream fs = new FileStream("object.xml", FileMode.Create))
                        {
                            xSer.Serialize(fs, subject);
                        }
                        break;
                    }
                case 4:
                    {
                        using (var fs = new StreamWriter("object.json"))
                        {
                            fs.Write(JsonSerializer.Serialize(subject));
                        }
                        break;
                    }
            }
        }

        public object Desirialize()
        {
            switch (type)
            {
                case 1:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream("object.dat", FileMode.Open))
                    {
                        return formatter.Deserialize(fs);
                    }

                case 2:
                    {
                        SoapFormatter soapFormatter = new SoapFormatter();
                        using (Stream fStream = new FileStream("object.dat", FileMode.Open))

                        {
                            return soapFormatter.Deserialize(fStream);
                        }
                    }
                case 3:
                    {
                        XmlSerializer xSer = new XmlSerializer(typeof(T));
                        using (FileStream fs = new FileStream("object.xml", FileMode.Open))
                        {
                            return xSer.Deserialize(fs);
                        }
                    }
                case 4:
                    {
                        using (var fs = new StreamReader("object.json"))
                        {
                            return JsonSerializer.Deserialize<T>(fs.ReadToEnd());
                        }
                    }
            }
            return null;
        }
    }
}