using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ColourLovers.Model.Stats
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "stats")]
    public class Stats
    {
        [XmlElement("total")]
        public int Total { get; set; }
    }
}