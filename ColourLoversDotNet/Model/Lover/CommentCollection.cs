using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ColourLovers.Model.Lover
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "comments")]
    public class CommentCollection
    {
        [XmlIgnore]
        public Comment this[int index]
        {
            get { return Comments[index]; }
            set { Comments[index] = value; }
        }

        [XmlElement("comment", Form = XmlSchemaForm.Unqualified)]
        public Comment[] Comments { get; set; }
    }
}
