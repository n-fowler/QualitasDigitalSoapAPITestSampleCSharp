using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualitasDigitalSoapAPITestSampleCSharp.src.TestClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.oorsprong.org/websamples.countryinfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.oorsprong.org/websamples.countryinfo", IsNullable = false)]
    public partial class CountryCurrencyResponse
    {

        private CountryCurrencyResponseCountryCurrencyResult countryCurrencyResultField;

        /// <remarks/>
        public CountryCurrencyResponseCountryCurrencyResult CountryCurrencyResult
        {
            get
            {
                return this.countryCurrencyResultField;
            }
            set
            {
                this.countryCurrencyResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryCurrencyResponseCountryCurrencyResult
    {

        private string sISOCodeField;

        private string sNameField;

        /// <remarks/>
        public string sISOCode
        {
            get
            {
                return this.sISOCodeField;
            }
            set
            {
                this.sISOCodeField = value;
            }
        }

        /// <remarks/>
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
    }


}
