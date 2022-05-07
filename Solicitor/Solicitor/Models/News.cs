using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solicitor.Models
{
    [Table("News")]
    public class News
    {
        [Key]
        public int NewsID { get; set; }

       
        public string Title { get; set; }

      
        public string PageUrl { get; set; }

     
        public DateTime Date { get; set; }

        public bool Status { get; set; }

      
        public string Description { get; set; }
    }
}