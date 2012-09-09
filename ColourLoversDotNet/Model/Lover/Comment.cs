using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace ColourLovers.Model.Lover
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class Comment
    {
        private readonly XmlDocument _document = new XmlDocument();

        private string _userName;
        private string _comments;

        [XmlElement("commentDate")]
        public string Date { get; set; }

        [XmlIgnore]
        public string UserName
        {
            get { return UserNameValue.Value; }
        }

        [XmlElement("commentUserName")]
        public XmlCDataSection UserNameValue
        {
            get
            {
                return _document.CreateCDataSection(_userName);
            }
            set
            {
                _userName = value.Value;
            }
        }

        [XmlIgnore]
        public string Comments
        {
            get { return CommentsValue.Value; }
        }

        [XmlElement("commentComments")]
        public XmlCDataSection CommentsValue
        {
            get
            {
                return _document.CreateCDataSection(_comments);
            }
            set
            {
                _comments = value.Value;
            }
        }
    }
}
