﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RssReader.Model
{
    public class CData
    {
        public string ActualString { get; set; }
    } 

    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        private string pubDate;

        public string PubDate
        {
            get { return pubDate; }
            set 
            { 
                pubDate = value;
                PublishedDate = DateTime.Now;//DateTime.ParseExact(pubDate, "ddd, dd MMM yyyy HH:mm:ss GMT", CultureInfo.InvariantCulture);
            }
        }
        public DateTime PublishedDate { get; set; }
        
        [XmlElement(ElementName = "creator", Namespace = "https://purl.org/dc/elements/1.1/")]
        public string Creator { get; set; }

    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
    }       

    [XmlRoot(ElementName = "rss")]
    public class FinZenBlog
    {
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
    }
    
}
