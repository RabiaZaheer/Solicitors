using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solicitor.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        public string Title { get; set; }

        [NotMapped]
        public HttpPostedFileBase MapPhoto { get; set; }

        public string Photo { get; set; }

        public bool Status { get; set; }
    }
}