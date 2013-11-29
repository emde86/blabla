using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace rndTestConsole
{
    [Serializable]
    [XmlRoot("result")]
    public class TimeZoneResult
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("message")]
        public string Message { get; set; }

        [XmlElement("countryCode")]
        public string CountryCode { get; set; }

        [XmlElement("zoneName")]
        public string ZoneName { get; set; }

        [XmlElement("abbreviation")]
        public string Abbreviation { get; set; }

        [XmlElement("gmtOffset")]
        public int GmtOffset { get; set; }

        [XmlElement("dst")]
        public int Dst { get; set; }

        [XmlElement("timestamp")]
        public long Timestamp { get; set; }

        [XmlIgnore]
        public DateTime DateTime
        {
            get
            {
                return (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(this.Timestamp);
            }
        }
    }
}
