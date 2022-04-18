using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public class Link
    {
        public Link()
        {
            HashSet<Link> link = new HashSet<Link>();
        }

        public int LinkID { get; set; }

       
        public string Title { get; set; }

      
        public string Url { get; set; }

        public int ParentID { get; set; }
        public bool IsLink { get; set; }
        public bool IsHidden { get; set; }
    }
}
