using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ColourLovers.Model.Color
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class RedGreenBlue
    {
        [XmlElement("red")]
        public int Red { get; set; }

        [XmlElement("green")]
        public int Green { get; set; }

        [XmlElement("blue")]
        public int Blue { get; set; }
    }
}
