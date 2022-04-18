using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PGSolicitors.Models;
namespace PGSolicitors.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        private IRespository<Service> respositoryService;
        private IRespository<SubService> respositorySubService;
        private IRespository<Link> respositoryLink;

        public LayoutController(IRespository<Service> service, IRespository<SubService> subService,  IRespository<Link> link)
        {
            respositoryService = service;
            respositorySubService = subService;
            respositoryLink = link;
        }

        public ActionResult Index()
        {
            return View();
        }

      
       


    }
}