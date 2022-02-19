using NUnit.Framework;
using QualitasDigitalSoapAPITestSampleCSharp.src.ResourceHandling;
using QualitasDigitalSoapAPITestSampleCSharp.src.SoapHandling;
using QualitasDigitalSoapAPITestSampleCSharp.src.TestClasses;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;

namespace QualitasDigitalSoapAPITestSampleCSharp
{
    public class SampleAPITest
    {
        [Test]
        public async Task SampleAPITestResponseCapital()
        {
            //Arrange all necessary preconditions and inputs
            SoapHandler soapHandler = new SoapHandler();
            string request = ResourceHandler.ReadResource("SoapTestDataCapitalCity.xml");
            string testUrl = "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso";

            //Act on the object or method under test
            string? response = await soapHandler.CreateSoapEnvelope(testUrl, request);
            CapitalCityResponse? capitalCityResponse = SoapDeserializer.DeserializeInnerSoapObject<CapitalCityResponse>(response);

            //Assert that the expected results have occurred
            Assert.AreEqual("Washington", capitalCityResponse.CapitalCityResult);

            return;
        }

        [Test]
        public async Task SampleAPITestResponseCurrency()
        {
            //Arrange all necessary preconditions and inputs
            SoapHandler soapHandler = new SoapHandler();
            string request = ResourceHandler.ReadResource("SoapTestDataCountryCurrency.xml");
            string testUrl = "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso";

            //Act on the object or method under test
            string? response = await soapHandler.CreateSoapEnvelope(testUrl, request);
            CountryCurrencyResponse? countryCurrencyResponse = SoapDeserializer.DeserializeInnerSoapObject<CountryCurrencyResponse>(response);

            //Assert that the expected results have occurred
            Assert.AreEqual("USD", countryCurrencyResponse.CountryCurrencyResult.sISOCode);
            Assert.AreEqual("Dollars", countryCurrencyResponse.CountryCurrencyResult.sName);

            return;
        }

        [Test]
        public async Task SampleAPITestResponseFlag()
        {
            //Arrange all necessary preconditions and inputs
            SoapHandler soapHandler = new SoapHandler();
            string request = ResourceHandler.ReadResource("SoapTestDataCountryFlag.xml");
            string testUrl = "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso";

            //Act on the object or method under test
            string? response = await soapHandler.CreateSoapEnvelope(testUrl, request);
            CountryFlagResponse? countryFlagResponse = SoapDeserializer.DeserializeInnerSoapObject<CountryFlagResponse>(response);
            
            //Assert that the expected results have occurred
            Assert.AreEqual("http://www.oorsprong.org/WebSamples.CountryInfo/Flags/USA.jpg", countryFlagResponse.CountryFlagResult);

            return;
        }

        [Test]
        public async Task SampleAPITestResponsePhoneCode()
        {
            //Arrange all necessary preconditions and inputs
            SoapHandler soapHandler = new SoapHandler();
            string request = ResourceHandler.ReadResource("SoapTestDataCountryPhoneCode.xml");
            string testUrl = "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso";

            //Act on the object or method under test
            string? response = await soapHandler.CreateSoapEnvelope(testUrl, request);
            CountryIntPhoneCodeResponse? countryIntPhoneCodeResponse = SoapDeserializer.DeserializeInnerSoapObject<CountryIntPhoneCodeResponse>(response);

            //Assert that the expected results have occurred
            Assert.AreEqual(1, countryIntPhoneCodeResponse.CountryIntPhoneCodeResult);

            return;
        }
    }
}