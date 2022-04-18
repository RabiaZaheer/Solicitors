using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public class DefautViewModel
    {
       
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Service> TopServices { get; set; }
        

        public DefautViewModel(
                                IRespository<News> news,
                                IRespository<Service> service)
        {

           
            News = news.GetAll().Where(x => x.Status == true).OrderByDescending(x => x.NewsID).Take(5);
            Services = service.GetAll().ToList();
            TopServices = service.GetAll().Where(s => s.ShowDefaultPage == true).ToList();
           
        }
    }
}