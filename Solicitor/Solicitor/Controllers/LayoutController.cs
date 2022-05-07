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

        public LayoutController( IRespository<Link> link)
        {
            
            respositoryLink = link;
        }

        public ActionResult Index()
        {
            return View();
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