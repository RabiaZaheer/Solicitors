using Solicitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solicitor.Controllers
{ 
    public class DefaultController : Controller
    {             
       
        private readonly IRespository<News> respositoryNews;

        public DefaultController()
        {
        }

        public DefaultController(                            
                                IRespository<News> news
                               )
                              
        {
          
            respositoryNews = news;
          
          
        }

        public ActionResult Index()
        {
            DefautViewModel model = new DefautViewModel( respositoryNews,
                                                       
                                                       
                                                        new Claim());
            return View(model);
        }
    }
}