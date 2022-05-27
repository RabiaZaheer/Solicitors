using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solicitor.Models;

namespace Solicitor.Controllers
{
    public class ServicesController : Controller
    {
      
        private IRespository<Service> respositoryService;
        private IRespository<SubService> respositoryServiceDetail;
        private IRespository<News> respositoryNews;

        public ServicesController(IRespository<Service> service, IRespository<SubService> subService, IRespository<News> news)
        {
            respositoryService = service;
            respositoryServiceDetail = subService;
            respositoryNews = news;
        }

        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Service(string pageUrl)
        {
            SubService subService = respositoryServiceDetail.GetAll().FirstOrDefault(x => x.PageUrl == pageUrl);
            return View(subService);
        }
        public ActionResult AllServices()
        {
            IEnumerable<Service> Services = respositoryService.GetAll().ToList();
            return View(Services);
        }
    }
}