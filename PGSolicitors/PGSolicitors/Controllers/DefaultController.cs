using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PGSolicitors.Models;

namespace PGSolicitors.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        
        private readonly IRespository<News> respositoryNews;
        private readonly IRespository<Service> respositoryService;
       

        public DefaultController(IRespository<News> news,IRespository<Service> service)
        {
            respositoryNews = news;
            respositoryService = service;
        }

        public ActionResult Index()
        {
            DefautViewModel model = new DefautViewModel(respositoryNews,
                                                        respositoryService);
            return View(model);
        }
    }
}