using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_2_2
{
    public class LinkTableItem
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        // Конструктор по умолчанию
        public LinkTableItem()
        { }

        public LinkTableItem(string text, string url)
        {
            this.text = text;
            this.url = url;
        }
    }
}