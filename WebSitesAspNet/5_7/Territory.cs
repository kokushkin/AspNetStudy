using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_7
{
    public class Territory
    {
        public string ID;
        public string Description;

        public Territory(string id, string description)
        {
            this.ID = id;
            this.Description = description;
        }

        public Territory() { }
    }
}