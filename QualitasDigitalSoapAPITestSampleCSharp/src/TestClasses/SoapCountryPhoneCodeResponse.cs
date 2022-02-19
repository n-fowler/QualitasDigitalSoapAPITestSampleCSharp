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
    public partial class CountryIntPhoneCodeResponse
    {

        private byte countryIntPhoneCodeResultField;

        /// <remarks/>
        public byte CountryIntPhoneCodeResult
        {
            get
            {
                return this.countryIntPhoneCodeResultField;
            }
            set
            {
                this.countryIntPhoneCodeResultField = value;
            }
        }
    }


}
