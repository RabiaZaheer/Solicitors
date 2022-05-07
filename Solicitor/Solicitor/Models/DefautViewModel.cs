using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solicitor.Models
{
    public class DefautViewModel
    {
        
        public IEnumerable<News> News { get; set; }
           
      
        public Claim Claim { get; set; }

        public DefautViewModel( 
                                IRespository<News> news,
                               
                               
                                Claim claim)
        {

          
            News = news.GetAll().Where(x => x.Status == true).OrderByDescending(x => x.NewsID).Take(5);
           
           
            Claim = claim;
        }
    }
}