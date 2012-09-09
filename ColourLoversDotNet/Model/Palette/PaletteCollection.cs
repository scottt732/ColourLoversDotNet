using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ColourLovers.Model.Palette
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "palettes")]
    public class PaletteCollection
    {
        [XmlIgnore]
        public Palette this[int index]
        {
            get { return Palettes[index]; }
            set { Palettes[index] = value; }
        }

        [XmlElement("palette")]
        public Palette[] Palettes { get; set; }

        [XmlAttribute("numResults")]
        public int NumResults { get; set; }

        [XmlAttribute("totalResults")]
        public int TotalResults { get; set; }
    }
}
