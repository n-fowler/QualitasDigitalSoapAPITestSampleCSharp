using System.IO;
using System.Reflection;

namespace QualitasDigitalSoapAPITestSampleCSharp.src.ResourceHandling
{
    public static class ResourceHandler
    {
        public static string ReadResource(string embeddedResourceName, string directory = "QualitasDigitalSoapAPITestSampleCSharp.src.TestData")
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"{directory}.{embeddedResourceName}";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }
    }
}
