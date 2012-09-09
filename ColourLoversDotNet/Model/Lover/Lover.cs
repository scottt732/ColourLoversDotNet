using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace ColourLovers.Model.Lover
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class Lover
    {
        private readonly XmlDocument _document = new XmlDocument();

        private string _userName;
        private string _location;
        private string _url;
        private string _apiUrl;

        [XmlIgnore]
        public string UserName
        {
            get { return UserNameValue.Value; }
        }

        [XmlElement("userName")]
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

        [XmlElement("dateRegistered")]
        public string DateRegistered { get; set; }

        [XmlElement("dateLastActive")]
        public string DateLastActive { get; set; }

        [XmlElement("rating")]
        public int Rating { get; set; }

        [XmlIgnore]
        public string Location
        {
            get { return LocationValue.Value; }
        }

        [XmlElement("location")]
        public XmlCDataSection LocationValue
        {
            get
            {
                return _document.CreateCDataSection(_location);
            }
            set
            {
                _location = value.Value;
            }
        }

        [XmlElement("numColors")]
        public string NumColors { get; set; }

        [XmlElement("numPalettes")]
        public string NumPalettes { get; set; }

        [XmlElement("numPatterns")]
        public string NumPatterns { get; set; }

        [XmlElement("numCommentsMade")]
        public string NumCommentsMade { get; set; }

        [XmlElement("numLovers")]
        public string NumLovers { get; set; }

        [XmlElement("numCommentsOnProfile")]
        public string NumCommentsOnProfile { get; set; }

        [XmlIgnore]
        public string Url
        {
            get { return UrlValue.Value; }
        }

        [XmlElement("url")]
        public XmlCDataSection UrlValue
        {
            get
            {
                return _document.CreateCDataSection(_url);
            }
            set
            {
                _url = value.Value;
            }
        }

        [XmlIgnore]
        public string ApiUrl
        {
            get { return ApiUrlValue.Value; }
        }

        [XmlElement("apiUrl")]
        public XmlCDataSection ApiUrlValue
        {
            get
            {
                return _document.CreateCDataSection(_apiUrl);
            }
            set
            {
                _apiUrl = value.Value;
            }
        }
        
        [XmlElement("comments")]
        public CommentCollection Comments { get; set; }
    }
}
