using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solicitor.Models;

namespace Solicitor.Controllers
{
    public class LayoutController : Controller
    {
      
        private IRespository<Link> respositoryLink;
        private IRespository<Service> respositoryService;
        private IRespository<SubService> respositorySubService;
        public LayoutController( IRespository<Link> link,IRespository <Service> service,IRespository<SubService> subService)
        {
            respositoryService = service;
            respositorySubService = subService;
            respositoryLink = link;
        }

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult GetServices()
        {
            IEnumerable<Service> Services = respositoryService.GetAll().Where(s => s.Status == true).ToList();
            return PartialView("~/Views/Shared/_ServiceMenu.cshtml", Services);
        }

        [ChildActionOnly]
        public PartialViewResult GetResponsiveServices()
        {
            IEnumerable<Service> Services = respositoryService.GetAll().Where(s => s.Status == true).ToList();
            return PartialView("~/Views/Shared/_ResponsiveServiceMenu.cshtml", Services);
        }

        [ChildActionOnly]
        public PartialViewResult GetSubService(int serviceID)
        {
            IEnumerable<SubService> subService = respositorySubService.GetAll().Where(s => s.ServiceID == serviceID);
            return PartialView("~/Views/Shared/_SubServiceMenu.cshtml", subService);
        }

        [ChildActionOnly]
        public PartialViewResult GetResponsiveSubService(int serviceID)
        {
            IEnumerable<SubService> subService = respositorySubService.GetAll().Where(s => s.ServiceID == serviceID);
            return PartialView("~/Views/Shared/_ResponsiveSubServiceMenu.cshtml", subService);
        }



        [ChildActionOnly]
        public PartialViewResult GetLinks()
        {
            IEnumerable<Link> links = respositoryLink.GetAll().Where(l=>l.ParentID==0);
            return PartialView("~/Views/Shared/_PagesMenu.cshtml", links);
        }

        [ChildActionOnly]
        public PartialViewResult GetResponsiveLinks()
        {
            IEnumerable<Link> links = respositoryLink.GetAll().Where(l => l.ParentID == 0);
            return PartialView("~/Views/Shared/_ResponsivePageMenu.cshtml", links);
        }
    }
}