using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QualitasDigitalSoapAPITestSampleCSharp.src.SoapHandling
{
    public static class SoapDeserializer
    {
        public static T DeserializeInnerSoapObject<T>(string soapResponse)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(soapResponse);

            var soapBody = xmlDocument.GetElementsByTagName("soap:Body")[0];
            string innerObject = soapBody.InnerXml;

            XmlSerializer? deserializer = new XmlSerializer(typeof(T));

            using (StringReader reader = new StringReader(innerObject))
            {
                return (T)deserializer.Deserialize(reader);
            }
        }
    }
}
