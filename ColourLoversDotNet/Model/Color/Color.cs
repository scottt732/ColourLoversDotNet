﻿using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace ColourLovers.Model.Color
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class Color
    {
        private readonly XmlDocument _document = new XmlDocument();

        private string _title;
        private string _userName;
        private string _description;
        private string _url;
        private string _imageUrl;
        private string _badgeUrl;

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlIgnore]
        public string Title
        {
            get { return TitleValue.Value; }
        }

        [XmlElement("title")]
        public XmlCDataSection TitleValue
        {
            get
            {
                return _document.CreateCDataSection(_title);
            }
            set
            {
                _title = value.Value;
            }
        }

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

        [XmlElement("numViews")]
        public int NumViews { get; set; }

        [XmlElement("numVotes")]
        public int NumVotes { get; set; }

        [XmlElement("numComments")]
        public int NumComments { get; set; }

        [XmlElement("numHearts")]
        public decimal NumHearts { get; set; }

        [XmlElement("rank")]
        public int Rank { get; set; }

        [XmlElement("dateCreated")]
        public string DateCreated { get; set; }

        [XmlElement("hex")]
        public string Hex { get; set; }

        [XmlElement("rgb")]
        public RedGreenBlue RedGreenBlue { get; set; }

        public System.Drawing.Color ToColor()
        {
            return System.Drawing.Color.FromArgb(255, RedGreenBlue.Red, RedGreenBlue.Green, RedGreenBlue.Blue);
        }

        [XmlElement("hsv")]
        public HueSaturationValue HueSaturationValue { get; set; }

        [XmlIgnore]
        public string Description
        {
            get { return DescriptionValue.Value; }
        }

        [XmlElement("description")]
        public XmlCDataSection DescriptionValue
        {
            get
            {
                return _document.CreateCDataSection(_description);
            }
            set
            {
                _description = value.Value;
            }
        }

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
        public string ImageUrl
        {
            get { return ImageUrlValue.Value; }
        }

        [XmlElement("imageUrl")]
        public XmlCDataSection ImageUrlValue
        {
            get
            {
                return _document.CreateCDataSection(_imageUrl);
            }
            set
            {
                _imageUrl = value.Value;
            }
        }

        [XmlIgnore]
        public string BadgeUrl
        {
            get { return BadgeUrlValue.Value; }
        }

        [XmlElement("BadgeUrl")]
        public XmlCDataSection BadgeUrlValue
        {
            get
            {
                return _document.CreateCDataSection(_badgeUrl);
            }
            set
            {
                _badgeUrl = value.Value;
            }
        }

        [XmlElement("apiUrl")]
        public string ApiUrl { get; set; }
    }
}
