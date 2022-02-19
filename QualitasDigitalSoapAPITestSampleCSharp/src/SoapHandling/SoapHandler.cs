using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QualitasDigitalSoapAPITestSampleCSharp.src.SoapHandling
{
    public class SoapHandler
    {
        public async Task<string> CreateSoapEnvelope(string url, string soapString)
        {
            HttpResponseMessage response = await PostXmlRequest(url, soapString);
            string content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("SOAPAction", "http://tempuri.org/HelloWorld");

                return await httpClient.PostAsync(baseUrl, httpContent);
            }
        }
    }
}
