using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ColourLovers.Model.Color
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class HueSaturationValue
    {
        [XmlElement("hue")]
        public int Hue { get; set; }
        
        [XmlElement("saturation")]
        public int Saturation { get; set; }
        
        [XmlElement("value")]
        public int Value { get; set; }
    }
}
