using System;
using System.ComponentModel.DataAnnotations;

namespace Solicitor.Models
{
    public class Claim
    {
        [Key]
        public int ClaimID { get; set; }

        public string Name { get; set; }

    
        public string Email { get; set; }

        public string ContactNo { get; set; }

      
        public string Detail { get; set; }

        public DateTime Date { get; set; }
    }
}