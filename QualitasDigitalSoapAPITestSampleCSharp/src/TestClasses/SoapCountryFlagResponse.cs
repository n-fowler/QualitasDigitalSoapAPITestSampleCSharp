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
    public partial class CountryFlagResponse
    {

        private string countryFlagResultField;

        /// <remarks/>
        public string CountryFlagResult
        {
            get
            {
                return this.countryFlagResultField;
            }
            set
            {
                this.countryFlagResultField = value;
            }
        }
    }


}
