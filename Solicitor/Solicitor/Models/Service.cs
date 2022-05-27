using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solicitor.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string PageUrl { get; set; }

        public string Title { get; set; }

        public string IconTitle { get; set; }

       
        public string ShortDescription { get; set; }

        public bool Status { get; set; }

        public bool ShowDefaultPage { get; set; }

    }
}