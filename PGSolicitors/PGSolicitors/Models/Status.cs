using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public class Status
    {
        public Status()
        {
            HashSet<Status> status = new HashSet<Status>();
        }

        public int StatusID { get; set; }

        public string Title { get; set; }
    }
}