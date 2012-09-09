using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ColourLovers.Model.Color
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "colors")]
    public class ColorCollection
    {
        [XmlIgnore]
        public Color this[int index]
        {
            get { return Colors[index]; }
            set { Colors[index] = value; }
        }

        [XmlElement("color")]
        public Color[] Colors { get; set; }

        [XmlAttribute("numResults")]
        public int NumResults { get; set; }

        [XmlAttribute("totalResults")]
        public uint TotalResults { get; set; }
    }
}
