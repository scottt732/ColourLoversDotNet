using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ColourLovers.Model.Pattern
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType=true)]
    [XmlRoot(Namespace="", IsNullable=false, ElementName="patterns")]
    public class PatternCollection 
    {
        [XmlIgnore]
        public Pattern this[int index]
        {
            get { return Patterns[index]; }
            set { Patterns[index] = value; }
        }

        [XmlElement("pattern", Form = XmlSchemaForm.Unqualified)]
        public Pattern[] Patterns { get; set; }

        [XmlAttribute("numResults")]
        public int NumResults { get; set; }

        [XmlAttribute("totalResults")]
        public string TotalResults { get; set; }
    }
}