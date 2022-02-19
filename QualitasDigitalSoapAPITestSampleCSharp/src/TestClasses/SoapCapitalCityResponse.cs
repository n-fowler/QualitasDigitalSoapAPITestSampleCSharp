using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QualitasDigitalSoapAPITestSampleCSharp.src.TestClasses
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private CapitalCityResponse capitalCityResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.oorsprong.org/websamples.countryinfo")]
        public CapitalCityResponse CapitalCityResponse
        {
            get
            {
                return this.capitalCityResponseField;
            }
            set
            {
                this.capitalCityResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.oorsprong.org/websamples.countryinfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.oorsprong.org/websamples.countryinfo", IsNullable = false)]
    public partial class CapitalCityResponse
    {

        private string capitalCityResultField;

        /// <remarks/>
        public string CapitalCityResult
        {
            get
            {
                return this.capitalCityResultField;
            }
            set
            {
                this.capitalCityResultField = value;
            }
        }
    }


}
