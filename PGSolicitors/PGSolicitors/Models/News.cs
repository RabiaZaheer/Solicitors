using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public class News
    {
        
        public int NewsID { get; set; }

        public string Title { get; set; }

       
        public string PageUrl { get; set; }

      

        public bool Status { get; set; }

       
        public string Description { get; set; }
    }
}