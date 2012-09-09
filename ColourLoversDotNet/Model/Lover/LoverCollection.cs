using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ColourLovers.Model.Lover
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType=true)]
    [XmlRoot(Namespace="", IsNullable=false, ElementName="lovers")]
    public class LoverCollection
    {
        [XmlIgnore]
        public Lover this[int index]
        {
            get { return Lovers[index]; }
            set { Lovers[index] = value; }
        }

        [XmlElement("lover", Form = XmlSchemaForm.Unqualified)]
        public Lover[] Lovers { get; set; }

        [XmlAttribute("numResults")]
        public int NumResults { get; set; }

        [XmlAttribute("totalResults")]
        public int TotalResults { get; set; }
    }
}
