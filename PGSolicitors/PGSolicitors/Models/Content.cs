using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web.Mvc;

namespace PGSolicitors.Models
{
    public class Content
    {
        public int ContentID { get; set; }

       
        public string Title { get; set; }

       
        public string PageUrl { get; set; }

      
        public string PageTitle { get; set; }

        
        public string MetaKeywords { get; set; }

      
        public string MetaDescription { get; set; }

       
        public string Details { get; set; }

       
        public int ParentID { get; set; }
        public bool IsMenu { get; set; }
        public bool Status { get; set; }

       
        public IEnumerable<SelectListItem> ParentPage
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();
                using (SDBContext db = new SDBContext())
                {
                    foreach (Content item in db.Contents.ToList())
                    {
                        items.Add(new SelectListItem() { Text = item.Title, Value = Convert.ToString(item.ContentID) });
                    }
                    items.Insert(0, new SelectListItem { Text = "None", Value = "0" });
                }
                return items;
            }
        }

        public static string ParentPageTitle(int parentID)
        {
            string title = string.Empty;
            using (SDBContext db = new SDBContext())
            {
                if (parentID == 0)
                    title = "None";
                else
                    title = db.Contents.FirstOrDefault(c => c.ContentID == parentID).Title;
            }
            return title;
        }
    }
}