using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public class SubService
    {
        
        public int SubServiceID { get; set; }

        public int ServiceID { get; set; }

       
        public string Title { get; set; }

     
        public string PageUrl { get; set; }

       
        public string Description { get; set; }
    }
}