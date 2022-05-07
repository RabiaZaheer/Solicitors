using Solicitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solicitor.Controllers
{
    public class ContentsController : Controller
    {
        //instance variable
        private IRespository<Content> respository;
        private IRespository<News> respositoryNews;
       
        //Using DI (UnityConfig) via Constructor
        //UnityConfig in App_Start Folder 
        //IRespository<T> as parameter in constructor
        public ContentsController(IRespository<Content> content, IRespository<News> news)
        {
            respository = content;
            respositoryNews = news;
           
        }

        [HttpGet]
        public ActionResult Our(string pageUrl)
        {
            Content content = respository.GetAll().FirstOrDefault(x => x.PageUrl == pageUrl);
            if (content == null)
                return RedirectToAction("Index", "Default");
            return View(content);
        }

       
    }
}