using Solicitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solicitor.Controllers
{
    public class ClaimController : Controller
    {
        
        private readonly IRespository<News> respositoryNews;
     
       
        private IRespository<Claim> respositoryClaim;

        public ClaimController(
                                IRespository<News> news,
                                
                              
                                IRespository<Claim> claim)
        {
            
            respositoryNews = news;
           
           
            respositoryClaim = claim;
        }

        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Claim([Bind(Exclude = "ClaimID")] Claim claim)
        {
            DefautViewModel model = null;
            if (!ModelState.IsValid)
            {
                model = new DefautViewModel(
                                                          respositoryNews,
                                                          
                                                         
                                                          claim);

                return View("~/Views/Default/Index.cshtml", model);
            }


            if (ModelState.IsValid)
            {
                System.Threading.Thread.Sleep(3000);

                claim.Date = DateTime.Now;
                respositoryClaim.Create(claim);
                respositoryClaim.Save();
                //TempData["Message"] = "Thankyou, soon one of our team member will contact you.";

                model = new DefautViewModel( respositoryNews,new Claim());

                return View("~/Views/Default/Index.cshtml", model);
            }
            return View();
        }

        [HttpGet]
        public ActionResult MakeAClaim()
        {
            return View(new Claim());
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MakeAClaim([Bind(Exclude = "ClaimID")] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return View(claim);
            }

            if (ModelState.IsValid)
            {
                System.Threading.Thread.Sleep(3000);

                claim.Date = DateTime.Now;
                respositoryClaim.Create(claim);
                respositoryClaim.Save();
            }
            return View();
        }

        
    }
}