using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_2_2
{
    public class LinkTableEventArgs : EventArgs
    {
        private LinkTableItem selectedItem;
        public LinkTableItem SelectedItem
        {
            get { return selectedItem; }
        }

        private bool cancel = false;
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }

        public LinkTableEventArgs(LinkTableItem item)
        {
            selectedItem = item;
        }
    }
}