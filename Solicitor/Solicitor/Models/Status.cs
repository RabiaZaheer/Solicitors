using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Solicitor.Models
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